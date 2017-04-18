using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Transactions;
using System.Windows.Forms;
using ElectricStoreMetro.Annotations;
using ElectricStoreMetro.MainForm.Reports;
using ElectricStoreMetro.MainForm.Category;
using ElectricStoreMetro.MainForm.Return;
using ElectricStoreMetro.MainForm.Customer;
using ElectricStoreMetro.MainForm.Product;
using ElectricStoreMetro.MainForm.Accounts;
using System.Threading;

namespace ElectricStoreMetro.MainForm.Sale
{
    // ReSharper disable once InconsistentNaming
    public partial class frSales : Form
    {
        public frSales()
        {
            InitializeComponent();
        }
        DataSet _dsItem = new DataSet();
        string InvoiceType="";
        private enum PaymentType
        {
            Cash = 1,
            [UsedImplicitly]
            Card = 2
        }


        //private DataSet _dsItem;
        public decimal PurchasePrice = 0;
        public decimal SalePrice = 0;
        private void frSales_Load(object sender, EventArgs e)
        {

            initialize();

        }

        private void initialize()
        {
            #region ORDER-NO

            bool isAlreadyExist = true;

            try
            {
                while (isAlreadyExist)
                {
                    string orderNo = GenerateOrderNo();
                    isAlreadyExist = CheckOrderExistance(orderNo);
                    txtInvID.Text = orderNo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    @"Error while generating Order No. Pease check below details for reference.
            Details:  " + ex.Message, @"Generate Order No", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
            //initialize the grid(empty)
            dgvCart.DataSource = SelectProductClass.InitializeDGV();

            //load stock available
            //PopulateStockGrid();

            //load default customer
            txtCustID.Text = Properties.Settings.Default["WalkingCustomerID"].ToString();
            txtCustName.Text = @"WALK IN CUSTOMER";

            //set default date
            txtInvDate.Text = DateTime.Now.Date.ToShortDateString();

            //populate search by category combobox
            DataSet d = CategoryClass.Select();
            cboSearchCat.DataSource = d.Tables[0].DefaultView;
            cboSearchCat.DisplayMember = "Name";
            cboSearchCat.ValueMember = "CatID";

            //POPULATE UNITS
            cboMeasurement.DataSource = ProductClass.PopulateMeasurementDropDown().Tables[0].DefaultView;
            cboMeasurement.DisplayMember = "Name";
            cboMeasurement.ValueMember = "MeasurementID";

            btnLoadAll.PerformClick();
        }

        private void PopulateStockGrid()
        {
            _dsItem.Clear();
            int minStockQty = Convert.ToInt32(Properties.Settings.Default["MinStock"]);
            _dsItem = Product.ProductClass.Select(minStockQty);
            //if (dgvItem != null) 
            dgvItem.DataSource = _dsItem.Tables[0].DefaultView;
        }

        private string GenerateOrderNo()
        {
            string orderNo;
            try
            {
                var rnd = new Random();
                long orderPart1 = rnd.Next(100000, 9999999);
                long orderPart2 = rnd.Next(1000, 9999);
                orderNo = "SN-" + orderPart1 + "-" + orderPart2;

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    @"Error while generating Order ID from Database.Please check below details for reference
                Details: " + ex.Message, @"Generate Order ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                orderNo = "";
            }
            return orderNo;
        }

        private bool CheckOrderExistance(string orderNo)
        {
            bool orderNoExist = false;

            try
            {
                using (var con = new SqlConnection(DBConnection.cn))
                {
                    string query = "SELECT * FROM ORDERS WHERE OrderNo=@orderNo";
                    using (var cmd = new SqlCommand(query, con))
                    {
                        var dtAnyData = new DataTable();
                        con.Open();
                        cmd.Parameters.AddWithValue("@orderNo", orderNo);
                        SqlDataReader reader = cmd.ExecuteReader();
                        dtAnyData.Load(reader);
                        if (dtAnyData.Rows.Count > 0)
                        {
                            orderNoExist = true;
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format("Error while checking order existance from database.Please check below details for reference.\nDetails: {0}", ex.Message), @"Check order No Existance", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            return orderNoExist;
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            //Width = 1000;
            using (ShopDBEntities _context = new ShopDBEntities())
            {
                var s = (from u in _context.Customers select u).ToList();
                dgvCustomer.DataSource = s;
            }
        }

        private void CalculateTotalAmount()
        {
            try
            {
                decimal unitPrice = Convert.ToDecimal((txtUnitPrice.Text));
                int quantity = Convert.ToInt32(txtSaleQty.Text);

                decimal totalPrice = unitPrice * quantity;
                txtTotalAmt.Text = totalPrice.ToString(CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {

            }
        }

        private void txtSaleQty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txtAvlQty.Text) < Convert.ToDecimal(txtSaleQty.Text))
                {
                    MessageBox.Show(@"Not much stock available.Please select quantity again", "Insufficient stock", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txtSaleQty.Text = "1";
                }
            }
            catch (FormatException)
            {

            }
            if (txtSaleQty.Text == string.Empty || txtSaleQty.Text == @"0")
                MessageBox.Show(@"Invalid quantity Selected. please try again.", @"Invalid Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            Calculate();
        }

        private void txtItemID_TextChanged(object sender, EventArgs e)
        {
            btnAddtoCart.Enabled = !string.IsNullOrEmpty((txtItemID.Text));
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {

        }

        private void dgvCart_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Total();
        }

        private void Total()
        {
            try
            {
                decimal discount = Convert.ToDecimal(txtDiscount.Text);
                decimal amount = 0;

                for (int i = 0; i < dgvCart.Rows.Count; ++i)
                {
                    amount += Convert.ToDecimal(dgvCart.Rows[i].Cells["Amount"].Value);
                }
                decimal toPay = amount - discount;

                txtGrandTotal.Text = amount.ToString();

                lblTotalToPay.Text = toPay.ToString();
                txtTotalItems.Text = dgvCart.Rows.Count.ToString();

                txtPaymentDue.Text = Convert.ToString((Convert.ToDecimal(lblTotalToPay.Text) - Convert.ToDecimal(txtTotalPayment.Text)));
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while calculating Grand Total\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtDiscount_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void dgvCart_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Total();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiscount.Text))
                txtDiscount.Text = "0";

            Total();
        }

        private void txtTotalPayment_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalPayment.Text))
            {
                txtTotalPayment.Text = "0";
            }
            Total();
        }

        private void txtFullPayment_Click(object sender, EventArgs e)
        {
            txtTotalPayment.Text = lblTotalToPay.Text;
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCart.SelectedRows[0];
                dgvCart.Rows.Remove(row);
            }

        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count > 0)
                dgvCart.DataSource = SelectProductClass.InitializeDGV();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {



        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
#region RECEIPT
            var headerFont = new Font("Arial", 20, FontStyle.Regular);
            var subHeaderFont = new Font("Courier New", 16, FontStyle.Regular);
            var font = new Font("Courier New", 8, FontStyle.Regular);
            int itemID = 10;
            int item = 100;
            int qty = item + 400;
            int price = qty + 100;
            int amount = price + 100;
            int yPos = 270;
            //InvoiceType = "Sale Invoice";

            string dash = "==============================================================================================================";
            string SingleDash = "------------------------------------------------------------------------------------------------------------------";

            e.Graphics.DrawString(dash, font, Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString(dash, font, Brushes.Black, new Point(10, 230));
            e.Graphics.DrawString(SingleDash, font, Brushes.Black, new Point(itemID, 110));
            

            //Image img = Resources.accounts;
            //e.Graphics.DrawImage(img, 400, 2, img.Width, img.Height);
            //SELECT ACCOUNT INFO
            DataSet ds = SelectProductClass.Select();
            string name = ds.Tables[0].Rows[0]["Name"].ToString();
            string slogan = ds.Tables[0].Rows[0]["Slogan"].ToString();
            string address = ds.Tables[0].Rows[0]["Address"].ToString();
            string contact = ds.Tables[0].Rows[0]["Contact"].ToString();

            e.Graphics.DrawString("Invoice Type: "+InvoiceType, font, Brushes.Black, new Point(10, 170));

            //shop name, slogan, address, contact
            e.Graphics.DrawString(name, headerFont, Brushes.Black, new Point(240, 20));
            e.Graphics.DrawString(slogan, subHeaderFont, Brushes.Black, new Point(200, 50));
            e.Graphics.DrawString(address, subHeaderFont, Brushes.Black, new Point(180, 70));
            e.Graphics.DrawString(contact, subHeaderFont, Brushes.Black, new Point(260, 90));

            e.Graphics.DrawString("Customer Name: " + txtCustName.Text, font, Brushes.Black, new Point(10, 130));
            e.Graphics.DrawString("Order No: " + txtInvID.Text, font, Brushes.Black, new Point(10, 150));
            e.Graphics.DrawString("Date: " + DateTime.Now, font, Brushes.Black, new Point(600, 150));


            e.Graphics.DrawString("PRODUCT ID ", font, Brushes.Black, new Point(itemID, 240));
            e.Graphics.DrawString("ITEM ", font, Brushes.Black, new Point(item, 240));
            e.Graphics.DrawString("QTY ", font, Brushes.Black, new Point(qty, 240));
            e.Graphics.DrawString("PRICE ", font, Brushes.Black, new Point(price, 240));
            e.Graphics.DrawString("AMOUNT ", font, Brushes.Black, new Point(amount, 240));
            
            for (int i = 0; i < dgvCart.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgvCart.Rows[i].Cells["ProductID"].Value.ToString(), font, Brushes.Black, new Point(itemID, yPos));
                e.Graphics.DrawString(dgvCart.Rows[i].Cells["NAME"].Value.ToString(), font, Brushes.Black, new Point(item, yPos));
                e.Graphics.DrawString(dgvCart.Rows[i].Cells["QUANTITY"].Value.ToString(), font, Brushes.Black, new Point(qty, yPos));
                e.Graphics.DrawString(dgvCart.Rows[i].Cells["PRICE"].Value.ToString(), font, Brushes.Black, new Point(price, yPos));
                e.Graphics.DrawString(dgvCart.Rows[i].Cells["AMOUNT"].Value.ToString(), font, Brushes.Black, new Point(amount, yPos));

                yPos += 20;
            }
            e.Graphics.DrawString(SingleDash, font, Brushes.Black, new Point(itemID, yPos + 10));
            e.Graphics.DrawString(SingleDash, font, Brushes.Black, new Point(itemID, yPos + 30));
            //e.Graphics.DrawString(dash, font, Brushes.Black, new Point(item, yPos + 10));

            e.Graphics.DrawString("Total", font, Brushes.Black, new Point(item, yPos + 20));
           // e.Graphics.DrawString(txtTotalItems.Text, font, Brushes.Black, new Point(qty, yPos + 20));
            e.Graphics.DrawString(txtGrandTotal.Text, font, Brushes.Black, new Point(amount, yPos + 20));
            e.Graphics.DrawString("Invoice Total  (RS): " +txtGrandTotal.Text, font, Brushes.Black, new Point(qty, yPos + 50));
            //e.Graphics.DrawString("Total To Pay: " + lblTotalToPay.Text, font, Brushes.Black, new Point(item, yPos + 60));
           // e.Graphics.DrawString("Discount: " + txtDiscount.Text, font, Brushes.Black, new Point(item, yPos + 80));
            e.Graphics.DrawString("Total Payment  (RS): " + txtTotalPayment.Text, font, Brushes.Black, new Point(qty, yPos + 70));
            e.Graphics.DrawString("Payment Due    (RS): " + txtPaymentDue.Text, font, Brushes.Black, new Point(qty, yPos + 90));
            e.Graphics.DrawString(SingleDash, font, Brushes.Black, new Point(itemID, yPos + 100));
            e.Graphics.DrawString("Software by Developer Studio: 923366536339", font, Brushes.Black, new Point(itemID, yPos + 110));
        }
#endregion
        private void metroButton1_Click(object sender, EventArgs e)
        {


        }

        private void frSales_Activated(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ModifyProductClass.OrderNo))
            {

            }
            else
            {
                MessageBox.Show("Product Refund");
                txtInvID.Text = ModifyProductClass.OrderNo;

                txtCustID.Text = ModifyProductClass.CustomerID.ToString();
                txtCustName.Text = ModifyProductClass.CustomerName;

                DataSet returnDs = SelectProductClass.SelectItemsForReturn(ModifyProductClass.OrderNo);
                dgvCart.DataSource = returnDs.Tables[0].DefaultView;

                DataSet returnOrderDs = SelectProductClass.SelectOrderForReturn(ModifyProductClass.OrderNo);

                //TRANSACTION DATE
                txtInvDate.Text = returnOrderDs.Tables[0].Rows[0][0].ToString();

                //GRAND TOTAL, TOTAL TO PAY
                //txtGrandTotal.Text = returnOrderDs.Tables[0].Rows[0][2].ToString();
                lblTotalToPay.Text = returnOrderDs.Tables[0].Rows[0][2].ToString();

                //DISCOUNT
                txtDiscount.Text = returnOrderDs.Tables[0].Rows[0][4].ToString();

                //TOTAL PAYMENT
                txtTotalPayment.Text = returnOrderDs.Tables[0].Rows[0][5].ToString();

                //PAYMENT DUE
                txtPaymentDue.Text = returnOrderDs.Tables[0].Rows[0][6].ToString();

                MessageBox.Show("Finished OK");




            }
        }

        private void txtSearchCode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = _dsItem.Tables[0].DefaultView;
                dv.RowFilter = "ItemID = " + txtSearchCode.Text;
            }
            catch
            {
                PopulateStockGrid();
            }
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = _dsItem.Tables[0].DefaultView;
                dv.RowFilter = "Name LIKE '%" + txtSearchName.Text.Trim() + "%'";
            }
            catch
            {
                PopulateStockGrid();
            }
        }

        private void cboSearchCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = _dsItem.Tables[0].DefaultView;
                dv.RowFilter = "Category LIKE '%" + cboSearchCat.Text.Trim() + "%'";
            }
            catch
            {
                PopulateStockGrid();
            }
        }

        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            PopulateStockGrid();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {

        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCustomer.Rows[e.RowIndex];
                txtCustID.Text = row.Cells[0].Value.ToString();
                txtCustName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            frCustomer fr = new frCustomer();
            fr.ShowDialog();
        }

        private void btnReturnTransaction_Click(object sender, EventArgs e)
        {
            frReturn r = new frReturn();
            r.ShowDialog();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            frUpdateOrder f = new frUpdateOrder();
            f.ShowDialog();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog dlg = new System.Windows.Forms.PrintPreviewDialog();
            //dlg.Height = 250;
            //dlg.Width = 15000;
            dlg.Document = PrintDocument;
            dlg.ShowDialog();

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count <= 0)
            {
                MessageBox.Show("Please fill cart first and try again.", "Empty Cart", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (var trans = new TransactionScope())
                {

                    #region ORDER
                    using (var db = new ShopDBEntities())
                    {
                        int oStatus;
                        if (Convert.ToDecimal(txtPaymentDue.Text) == 0)
                        {
                            oStatus = Convert.ToInt32(Properties.Settings.Default["CompleteOStatusID"]);
                        }
                        else
                        {
                            oStatus = Convert.ToInt32(Properties.Settings.Default["PendingOStatusID"]);
                        }

                        var order = new Order
                        {
                            OrderNo = txtInvID.Text,
                            TransactionDate = DateTime.Now.Date,
                            ClientID = Convert.ToInt32(txtCustID.Text),
                            TotalAmount = Convert.ToDecimal(lblTotalToPay.Text),
                            SalesTax = 0,
                            Discount = Convert.ToDecimal(txtDiscount.Text),
                            TotalPayment = Convert.ToDecimal(txtTotalPayment.Text),
                            PaymentDue = Convert.ToDecimal(txtPaymentDue.Text),
                            PaymentType = (int)PaymentType.Cash,
                            TotalToPay = Convert.ToDecimal(lblTotalToPay.Text),
                            Comments = txtComments.Text,
                            OrderStatusID = oStatus
                        };

                        db.Entry(order).State = EntityState.Added;
                        db.SaveChanges();
                    }
                    #endregion

                    #region ITEMS
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        using (var db = new ShopDBEntities())
                        {
                            var oItem = new OrderItem
                            {
                                OrderNo = txtInvID.Text,
                                ProductID = Convert.ToInt32(row.Cells["ProductID"].Value),
                                Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),
                                PurchasePrice = Convert.ToDecimal(row.Cells["PurchasePrice"].Value),
                                SalePrice = Convert.ToDecimal(row.Cells["Price"].Value),
                                TotalPrice = Convert.ToDecimal(row.Cells["Amount"].Value),
                                OrderDate = DateTime.Now.Date,
                                SaleUnitID=Convert.ToInt32(cboMeasurement.SelectedValue),
                                CustomerID=Convert.ToInt32(txtCustID.Text.Trim())
                            };

                            db.Entry(oItem).State = EntityState.Added;
                            db.SaveChanges();
                        }
                    }
                    #endregion

                    #region UPDATE QUANTITY
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        using (var context = new ShopDBEntities())
                        {
                            int itemid = Convert.ToInt32(row.Cells["ProductID"].Value);
                            var item = context.Items.SingleOrDefault(c => c.ItemID == itemid);
                            item.UsedQty = item.UsedQty + Convert.ToInt32(row.Cells["Quantity"].Value);

                            context.Entry(item).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                    }
                    #endregion

                    trans.Complete();
                }
                DialogResult result = MessageBox.Show("Print Slip?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InvoiceType = "Sale Invoice";
                    PrintPreviewDialog.Document = PrintDocument;
                    PrintPreviewDialog.Show();
                }
                Notifications.Notfication("Success", "Thanks for shopping here", Color.Green);


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR\n" + ex.Message);
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            dgvCart.DataSource = SelectProductClass.InitializeDGV();
            initialize();

            #region Enable Controls
            btnSelectCustomer.Enabled = true;
            gboxItemDetails.Enabled = true;
            dgvCart.Enabled = true;
            dgvItem.Enabled = true;
            dgvCustomer.Enabled = true;
            #endregion
            #region ORDER-NO

            bool isAlreadyExist = true;

            try
            {
                while (isAlreadyExist)
                {
                    string orderNo = GenerateOrderNo();
                    isAlreadyExist = CheckOrderExistance(orderNo);
                    txtInvID.Text = orderNo;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(
                    @"Error while generating Order No. Pease check below details for reference.
            Details:  " + ex.Message, @"Generate Order No", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
              DataTable sourceForCart = SelectProductClass.SelectedItem(txtItemID.Text, txtItemName.Text,
              Convert.ToInt32(txtConvertedQty.Text),
              Convert.ToDecimal(txtUnitPrice.Text), Convert.ToDecimal(txtTotalAmt.Text), Convert.ToDecimal(txtPurchasePrice.Text), Convert.ToDecimal(txtUnitPrice.Text), Convert.ToInt32(cboMeasurement.SelectedValue.ToString()));

            dgvCart.DataSource = sourceForCart;
        }

        private void btnCreateProductCategories_Click(object sender, EventArgs e)
        {
            frCategory f = new frCategory(); f.ShowDialog();
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            frProduct f = new frProduct(); f.ShowDialog();
        }

        private void btnCreateUserAccount_Click(object sender, EventArgs e)
        {
            frAccount f = new frAccount(); f.ShowDialog();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvItem_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvItem.Rows[e.RowIndex];
                txtSaleQty.Text = @"1";
                txtItemName.Text = row.Cells["Name"].Value.ToString();
                txtItemID.Text = row.Cells["ItemID"].Value.ToString();
                //txtUnitPrice.Text = row.Cells["Saleprice"].Value.ToString();
                //txtTotalAmt.Text = row.Cells["Saleprice"].Value.ToString();
                txtAvlQty.Text = row.Cells["RemQty"].Value.ToString();
                txtUnit.Text = row.Cells["UnitName"].Value.ToString();
                txtPurchasePrice.Text = row.Cells["PurchasePrice"].Value.ToString();
                // PurchasePrice = Convert.ToDecimal((row.Cells["PurchasePrice"].Value));
                //  SalePrice = Convert.ToDecimal((row.Cells["SalePrice"].Value));
                //txtSaleQty.Text = row.Cells["Saleprice"].Value.ToString();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
        private decimal CalulateTotalAmount(out decimal QuantityConverted, decimal UnitPrice, decimal SaleQty, string DefaultUnit, string UnitToConvertIn)
        {
            decimal TotalAmount = 0;
            decimal price = UnitPrice;
            decimal qty = SaleQty;
            QuantityConverted = 0;
            switch (DefaultUnit)
            {
                case "Meter":
                    switch (UnitToConvertIn)
                    {
                        case "Meter":
                            QuantityConverted = (qty * Properties.Settings.Default.metertometer);
                            TotalAmount = QuantityConverted * price;
                            break;

                        case "Yard":
                            QuantityConverted=(qty * Properties.Settings.Default.yardtometer);
                            TotalAmount =  QuantityConverted* price;
                            break;

                        case "Foot":
                            QuantityConverted = (qty * Properties.Settings.Default.foottometer);
                            TotalAmount = QuantityConverted * price;
                            break;
                    }
                    return TotalAmount;
                case "Foot":
                    switch (UnitToConvertIn)
                    {
                        case "Meter":
                            QuantityConverted = (qty * Properties.Settings.Default.metertofoot);
                            TotalAmount = QuantityConverted * price;
                            break;

                        case "Yard":
                            QuantityConverted = (qty * Properties.Settings.Default.yardtofoot);
                            TotalAmount = QuantityConverted * price;
                            break;

                        case "Foot":
                            QuantityConverted=(qty * Properties.Settings.Default.foottofoot);
                            TotalAmount = QuantityConverted * price;
                            break;
                    }
                    return TotalAmount;

                case "Yard":
                    switch (UnitToConvertIn)
                    {
                        case "Meter":
                            QuantityConverted = (qty * Properties.Settings.Default.metertoyard);
                            TotalAmount = QuantityConverted * price;
                            break;
                        case "Foot":
                            QuantityConverted = (qty * Properties.Settings.Default.foottoyard);
                            TotalAmount = QuantityConverted * price;
                            break;

                        case "Yard":
                            QuantityConverted = (qty * Properties.Settings.Default.yardtoyard);
                            TotalAmount = QuantityConverted * price;
                            break;
                    }
                    return TotalAmount;

                case "KG":
                    switch (UnitToConvertIn)
                    {
                        case "Foot":
                            QuantityConverted = (qty * Convert.ToDecimal(Properties.Settings.Default.foottokg));
                            TotalAmount = QuantityConverted * price;
                            break;

                        case "KG":
                            QuantityConverted = (qty * Convert.ToDecimal(Properties.Settings.Default.kgtokg));
                            TotalAmount = QuantityConverted * price;
                            break;
                    }
                     return TotalAmount;

                case "Pieces":
                     switch (UnitToConvertIn)
                    {
                         case "Pieces":
                            QuantityConverted = (qty * 1);
                            TotalAmount = QuantityConverted * price;
                            break;
                    }
                     return TotalAmount;

                default:
                    QuantityConverted = 0;
                    return TotalAmount = 0;
                    break;
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                decimal QuantityConverted = 0;
                txtTotalAmt.Text = CalulateTotalAmount(out QuantityConverted, 
                    Convert.ToDecimal(txtUnitPrice.Text), Convert.ToDecimal(txtSaleQty.Text),
                    txtUnit.Text, cboMeasurement.Text).ToString();
                //lblConvertedQty.Text = lblConvertedQty.Text + " " + cboMeasurement.Text;
                txtConvertedQty.Text = QuantityConverted.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

       

        private void txtUnitPrice_Click(object sender, EventArgs e)
        {

        }

        private void cboMeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnUpdateOrder_Click_1(object sender, EventArgs e)
        {
            #region validation
            if (txtUpdateOrderNo.Text.Trim()==string.Empty)
            {
                MessageBox.Show("Order No required. please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelAction.Visible = false;
                return;
            }
            else
            {
                panelAction.Visible = true;
            }
            #endregion
        }

        private void btnActionUpdateOrder_Click(object sender, EventArgs e)
        {
            try
            {
                /*1 VALIDATIONS
                 * 2 GET CART ITEMS
                 * 3 GET GRAND TOTAL FROM ORDER
                 * 4 GET CUSTOMER NAME AND ID
                 * 5 GET INVOICE DATE
                 */
            #region VALIDATIONS
                
                btnSelectCustomer.Enabled=false;

                gboxItemDetails.Enabled=false;

                dgvItem.Enabled=false;

                dgvCart.Enabled=false;

                btnProcessOrder.Enabled=false;

                btnProcessReturn.Enabled = false;

                btnProcessUpdate.Enabled = true;

                dgvCustomer.Enabled = false;
#endregion

            #region GET CART ITEMS
                dgvCart.DataSource = null;
                DataSet CartDS = ReturnClass.SelectCartItems(txtUpdateOrderNo.Text);
                dgvCart.DataSource = CartDS.Tables[0].DefaultView;
#endregion

            #region GET GRAND TOTAL FROM ORDER
                if(CartDS.Tables[0].Rows.Count>0)
                {
                    txtTotalPayment.Text = CartDS.Tables[0].Rows[0]["TotalPayment"].ToString();
                }
                else if (CartDS.Tables[0].Rows.Count <= 0)
                {
                    MessageBox.Show("No Record Found. Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                #endregion

            #region GET CUSTOMER NAME AND ID
                if(CartDS.Tables[0].Rows.Count>0)
                {
                    txtCustID.Text = CartDS.Tables[0].Rows[0]["CustomerID"].ToString();
                    txtCustName.Text = CartDS.Tables[0].Rows[0]["CustomerName"].ToString();
                }
                #endregion

            #region GET INVOICE DATE
                if(CartDS.Tables[0].Rows.Count>0)
                {
                    txtInvDate.Text=CartDS.Tables[0].Rows[0]["TransactionDate"].ToString();
                }
                #endregion
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            finally
            {
                panelAction.Visible=false;
            }
        }

        private void btnProcessUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //UPDADE ORDER TABLE
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    string orderNo = txtUpdateOrderNo.Text;
                    var updateOrder = db.Orders.SingleOrDefault(c => c.OrderNo == orderNo);
                    updateOrder.TotalPayment = Convert.ToDecimal(txtTotalPayment.Text);
                    if (txtPaymentDue.Text.Trim() == "0.00" || Convert.ToDecimal(txtPaymentDue.Text) == 0)
                    {
                        updateOrder.OrderStatusID=1;
                    }
                    else
                    {
                        updateOrder.OrderStatusID=2;
                    }
                    db.Entry(updateOrder).State = EntityState.Modified;
                    db.SaveChanges();
                    DialogResult result = MessageBox.Show("Print Slip?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result==DialogResult.Yes)
                    {
                        InvoiceType = "Update Order";
                        PrintPreviewDialog.Document = PrintDocument;
                        PrintPreviewDialog.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActionReturnItems_Click(object sender, EventArgs e)
        {
            try
            {
             /*1 Validations
             * 2 GET CART ITEMS
             * 3 GET GRAND TOTAL FROM ORDERS
             * 4 GET CUSTOMER DETAILS 
             * 5 GET INVOICE DATE
             */
            #region VALIDATIONS
            btnProcessOrder.Enabled = false;
            btnSelectCustomer.Enabled = false;
            btnProcessUpdate.Enabled = false;
            btnProcessReturn.Enabled = true;
            dgvCustomer.Enabled = false;
            #endregion
            #region GET CART ITEMS
            dgvCart.DataSource = null;
            DataSet CartDS = ReturnClass.SelectCartItems(txtUpdateOrderNo.Text);
            dgvCart.DataSource = CartDS.Tables[0].DefaultView;
            #endregion
            #region GET GRAND TOTAL FROM ORDER
            if (CartDS.Tables[0].Rows.Count > 0)
            {
                txtTotalPayment.Text = CartDS.Tables[0].Rows[0]["TotalPayment"].ToString();
            }
            else if (CartDS.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("No Record Found. Try Again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion
            #region GET CUSTOMER NAME AND ID
            if (CartDS.Tables[0].Rows.Count > 0)
            {
                txtCustID.Text = CartDS.Tables[0].Rows[0]["CustomerID"].ToString();
                txtCustName.Text = CartDS.Tables[0].Rows[0]["CustomerName"].ToString();
            }
            #endregion
            #region GET INVOICE DATE
            if (CartDS.Tables[0].Rows.Count > 0)
            {
                txtInvDate.Text = CartDS.Tables[0].Rows[0]["TransactionDate"].ToString();
            }
            #endregion
            }
           catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                panelAction.Visible = false;
            }
           
        }

        private void btnProcessReturn_Click(object sender, EventArgs e)
        {
            /*ACTIONS
             * 1. DELETE RESPECTIVE DATA FROM ORDER ITEMS AND ORDER TABLE
             * 2. INSERT STOCK BACK IN ITEMS TABLE
             * 3. SAVE DATA IN ORDERS TABLE
             * 4. SAVE DATA IN ORDER ITEMS TABLE
             * 5. REMOVE STOCK FROM ITEMS TABLE
             */
            try
            {
                using (TransactionScope trans = new TransactionScope())
                {
                    string orderno=txtUpdateOrderNo.Text;
                    #region DELETE FROM ORDERS
                    using (ShopDBEntities db = new ShopDBEntities())
                    {
                        var orderToRemove = db.Orders.SingleOrDefault(c => c.OrderNo == orderno);
                        db.Orders.Remove(orderToRemove);
                        db.Entry(orderToRemove).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    #endregion
                    #region DELETE FROM ORDER ITEMS
                    using (ShopDBEntities db = new ShopDBEntities())
                    {
                        var itemToRemove = db.OrderItems.FirstOrDefault(c => c.OrderNo == orderno);
                        db.OrderItems.Remove(itemToRemove);
                        db.Entry(itemToRemove).State = EntityState.Deleted;
                        db.SaveChanges();
                    }
                    #endregion
                    #region UPDATE QUANTITY
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        using (var context = new ShopDBEntities())
                        {
                            int itemid = Convert.ToInt32(row.Cells["ProductID"].Value);
                            var item = context.Items.SingleOrDefault(c => c.ItemID == itemid);
                            item.UsedQty = item.UsedQty - Convert.ToInt32(row.Cells["Quantity"].Value);

                            context.Entry(item).State = EntityState.Modified;
                            context.SaveChanges();
                        }
                    }
                    #endregion
                    
                    
                    trans.Complete();
                }
                
              
            }
            catch (Exception ex)
            {
                throw;
                MessageBox.Show(ex.Message);
                return;
            }
        }
    }
}
