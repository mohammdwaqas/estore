using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;
using ElectricStoreMetro.MainForm.Sale;
using ElectricStoreMetro.MainForm.Product;

namespace ElectricStoreMetro.MainForm.Return
{
    public partial class frReturn : Form
    {
        public frReturn()
        {
            InitializeComponent();
        }

        private void frReturn_Load(object sender, EventArgs e)
        {
            //LOAD MEASUREMENTS
            try
            {
                cboMeasurement.DataSource = ProductClass.PopulateMeasurementDropDown().Tables[0].DefaultView;
                cboMeasurement.DisplayMember = "Name";
                cboMeasurement.ValueMember = "MeasurementID";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error initializing form\ndetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (txtOrderNo.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please put valid order no and try again.", "Missing Order No", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DataSet returnDs = SelectProductClass.SelectItemsForReturn(txtOrderNo.Text);

            dgvProducts.DataSource = returnDs.Tables[0].DefaultView;
            if (returnDs.Tables[0].Rows.Count > 0)
            {
                DataSet returnOrderDs = SelectProductClass.SelectOrderForReturn(txtOrderNo.Text);

                lblInvDate.Text = returnOrderDs.Tables[0].Rows[0][0].ToString();

                lblTotalToPay.Text = returnOrderDs.Tables[0].Rows[0][2].ToString();

                lblDiscount.Text = returnOrderDs.Tables[0].Rows[0][4].ToString();

                lblTotalPayment.Text = returnOrderDs.Tables[0].Rows[0][5].ToString();

                lblPaymentDue.Text = returnOrderDs.Tables[0].Rows[0][6].ToString();
            }
            else
            {
                MessageBox.Show("No record found against order no " + txtOrderNo.Text + ".", "not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            frSales f = new frSales();

            f.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            #region SELECT VALUES IN TEXT BOXES
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                //ORDER NO
                txtOrder.Text = txtOrderNo.Text;
                //ORDER ITEM ID
                txtOrderItemID.Text = row.Cells["OrderItemsID"].Value.ToString();
                //ITEM NAME
                txtItemName.Text = row.Cells["Name"].Value.ToString();
                //ITEM ID
                txtItemID.Text = row.Cells["ProductID"].Value.ToString();
                //PRICE
                txtUnitPrice.Text = row.Cells["Price"].Value.ToString();
                //UNIT
                txtUnit.Text = row.Cells["Unit"].Value.ToString();
                //QUANTITY
                numQty.Value = Convert.ToDecimal(row.Cells["Quantity"].Value);
                txtQty.Text = row.Cells["Quantity"].Value.ToString();
                numQty.Maximum = Convert.ToDecimal(row.Cells["Quantity"].Value);

                //MEASUREMENT COMBOBOX
                cboMeasurement.SelectedValue = Convert.ToInt32(row.Cells["SaleUnitID"].Value);

            }




            #endregion

            if (numQty.Value != 0)
            {

                if (quantity == numQty.Value)
                {
                    MessageBox.Show("Will remove");

                    #region REMOVE
                    DialogResult result = MessageBox.Show("Product will be removed from order. Are you sure you want to continue?", "Confirmation required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (e.RowIndex >= 0)
                    {
                        if (result == DialogResult.Yes)
                        {
                            #region PRIVATE VARIABLES
                            DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                            int id = Convert.ToInt32(row.Cells[0].Value);
                            string orderNo = txtOrderNo.Text;
                            int itemId = Convert.ToInt32(row.Cells[1].Value);
                            int QtySold = Convert.ToInt32(row.Cells["Quantity"].Value);
                            decimal amt = Convert.ToDecimal(row.Cells["Amount"].Value);

                            //bool needsUpdate = false;
                            //int QtyToModify = Convert.ToInt32(txtQtyToRemove.Text.Trim());

                            //if (QtyToModify == QtySold)
                            //{
                            //    needsUpdate = false;
                            //}
                            //else if (QtyToModify < QtySold)
                            //{
                            //    needsUpdate = true;
                            //}
                            #endregion
                            using (TransactionScope trans = new TransactionScope())
                            {
                                #region OrderItems
                                //if (!needsUpdate)
                                //{
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var returnProduct = db.OrderItems.SingleOrDefault(c => c.OrderItemsID == id);
                                    db.OrderItems.Remove(returnProduct);

                                    db.Entry(returnProduct).State = EntityState.Deleted;
                                    db.SaveChanges();
                                }
                                //}
                                #endregion

                                #region Orders

                                if (dgvProducts.Rows.Count == 1) //IF ORDER HAS ONLY 1 ITEM THEN DELETE ORDER
                                {
                                    using (ShopDBEntities db = new ShopDBEntities())
                                    {
                                        var removeOrder = db.Orders.SingleOrDefault(o => o.OrderNo == orderNo);
                                        db.Orders.Remove(removeOrder);
                                        db.Entry(removeOrder).State = EntityState.Deleted;
                                        db.SaveChanges();
                                    }
                                }
                                else                           //UPDATE ORDER
                                {
                                    using (ShopDBEntities db = new ShopDBEntities())
                                    {
                                        var returnProductOrder = db.Orders.SingleOrDefault(w => w.OrderNo == orderNo);
                                        returnProductOrder.TotalAmount = returnProductOrder.TotalAmount - amt;
                                        returnProductOrder.TotalPayment = returnProductOrder.TotalPayment - amt;
                                        returnProductOrder.TotalToPay = returnProductOrder.TotalToPay - amt;
                                        db.Entry(returnProductOrder).State = EntityState.Modified;
                                        db.SaveChanges();
                                    }
                                }

                                #endregion

                                #region UpdateQty
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var updateQty = db.Items.SingleOrDefault(c => c.ItemID == itemId);
                                    updateQty.UsedQty = updateQty.UsedQty - QtySold;

                                    db.Entry(updateQty).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                                #endregion


                                trans.Complete();
                                MessageBox.Show("1 Item removed from the order successfully.", "Removed Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            btnGet.PerformClick();
                        }
                    }
                    #endregion
                }
                else if (numQty.Value < quantity)
                {
                    MessageBox.Show("Will update quantity");

                    #region UpdateQnatity
                    DialogResult Dresult = MessageBox.Show("I Item from Order will be updated. are you sure you want to proceed?", "Confirmation Required", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Dresult == DialogResult.Yes)
                    {
                        try
                        {
                            //
                            MessageBox.Show("Quantity Updated Successfully. ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnGet.PerformClick();
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error while updating Quantity.\nDetails: " + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    #endregion
                }
            }
            return;



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        decimal quantity = 0;
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                numQty.Enabled = true;
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dgvProducts.Rows[e.RowIndex];
                    //PRIVATE VARIABLES
                    quantity = Convert.ToDecimal(row.Cells["Quantity"].Value);

                    numQty.Maximum = quantity;
                    //numQty.Value = quantity;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            try
            {
                decimal QuantityConverted = 0;
                txtTotalAmt.Text = CalulateTotalAmount(out QuantityConverted,
                    Convert.ToDecimal(txtUnitPrice.Text), numQty.Value,
                    txtUnit.Text, cboMeasurement.Text).ToString();
                //lblConvertedQty.Text = lblConvertedQty.Text + " " + cboMeasurement.Text;
                txtConvertedQty.Text = QuantityConverted.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
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
                            QuantityConverted = (qty * Properties.Settings.Default.yardtometer);
                            TotalAmount = QuantityConverted * price;
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
                            QuantityConverted = (qty * Properties.Settings.Default.foottofoot);
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

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            Calculate();
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {


            //VALIDATION
            if (txtOrderNo.Text != string.Empty)
            {
                #region PRIVATE VARIABLES
                int id = Convert.ToInt32(txtItemID.Text);
                string orderNo = txtOrder.Text;
                int itemId = Convert.ToInt32(txtItemID.Text);
                decimal QtySold = Convert.ToDecimal(txtQty.Text) - numQty.Value;
                decimal amt = Convert.ToDecimal(txtOriginalAmt.Text) - Convert.ToDecimal(txtTotalAmt.Text);
                #endregion
                if (numQty.Value == 0)
                {
                    DialogResult result = MessageBox.Show("1 Item will be deleted from the order. want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {

                        using (TransactionScope trans = new TransactionScope())
                        {
                            #region OrderItems
                            using (ShopDBEntities db = new ShopDBEntities())
                            {
                                var returnProduct = db.OrderItems.SingleOrDefault(c => c.OrderItemsID == id);
                                db.OrderItems.Remove(returnProduct);

                                db.Entry(returnProduct).State = EntityState.Deleted;
                                db.SaveChanges();
                            }
                            #endregion

                            #region Orders

                            if (dgvProducts.Rows.Count == 1) //IF ORDER HAS ONLY 1 ITEM THEN DELETE ORDER
                            {
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var removeOrder = db.Orders.SingleOrDefault(o => o.OrderNo == orderNo);
                                    db.Orders.Remove(removeOrder);
                                    db.Entry(removeOrder).State = EntityState.Deleted;
                                    db.SaveChanges();
                                }
                            }
                            else                           //UPDATE ORDER
                            {
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var returnProductOrder = db.Orders.SingleOrDefault(w => w.OrderNo == orderNo);
                                    returnProductOrder.TotalAmount = returnProductOrder.TotalAmount - amt;
                                    returnProductOrder.TotalPayment = returnProductOrder.TotalPayment - amt;
                                    returnProductOrder.TotalToPay = returnProductOrder.TotalToPay - amt;
                                    db.Entry(returnProductOrder).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                            }

                            #endregion

                            #region UpdateQty
                            using (ShopDBEntities db = new ShopDBEntities())
                            {
                                var updateQty = db.Items.SingleOrDefault(c => c.ItemID == itemId);
                                updateQty.UsedQty = updateQty.UsedQty - QtySold;
                                db.Entry(updateQty).State = EntityState.Modified;
                                db.SaveChanges();
                            }
                            #endregion

                            trans.Complete();
                            MessageBox.Show("1 Item removed from the order successfully.", "Removed Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                else if (numQty.Value != 0 || numQty.Value != numQty.Maximum)
                {
                    DialogResult result = MessageBox.Show("1 Item will be modified from the order. want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (TransactionScope tranScope = new TransactionScope())
                            {
                                #region ORDERITEMS
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var updateProduct = db.OrderItems.SingleOrDefault(c => c.OrderItemsID == id);
                                    updateProduct.Quantity = updateProduct.Quantity - QtySold;
                                    updateProduct.TotalPrice = updateProduct.TotalPrice - amt;

                                    db.Entry(updateProduct).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                                #endregion

                                #region ORDER
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var returnProductOrder = db.Orders.SingleOrDefault(w => w.OrderNo == orderNo);
                                    returnProductOrder.TotalAmount = returnProductOrder.TotalAmount - amt;
                                    returnProductOrder.TotalPayment = returnProductOrder.TotalPayment - amt;
                                    returnProductOrder.TotalToPay = returnProductOrder.TotalToPay - amt;
                                    db.Entry(returnProductOrder).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                                #endregion

                                #region UPDATE QUANTITY
                                using (ShopDBEntities db = new ShopDBEntities())
                                {
                                    var updateQty = db.Items.SingleOrDefault(c => c.ItemID == itemId);
                                    updateQty.UsedQty = updateQty.UsedQty - QtySold;
                                    db.Entry(updateQty).State = EntityState.Modified;
                                    db.SaveChanges();
                                }
                                #endregion
                                tranScope.Complete();
                            }
                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show("Error\nDetails: " + ex.Message);
                            return;
                        }
                    }
                }
            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
