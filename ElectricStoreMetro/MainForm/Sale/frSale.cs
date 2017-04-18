using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Transactions;
using ElectricStoreMetro.Properties;

namespace ElectricStoreMetro.MainForm.Sale
{
    public partial class frSale : MetroFramework.Forms.MetroForm
    {
        public frSale()
        {
            InitializeComponent();
        }
        
        private void insertTestItems()
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                var order = new ElectricStoreMetro.Order();
                order.OrderNo="MYNUM";
                order.SalesTax=Convert.ToDecimal(10.10);
                order.TotalToPay=10000;
                order.TransactionDate = DateTime.Now;
                order.ClientID = 1;
                order.TotalAmount = 5000;

                db.Entry(order).State = EntityState.Added;
                db.SaveChanges();
                MessageBox.Show("Test Success");

            }
        }
        private void frSale_Load(object sender, EventArgs e)
        {
            dgv.DataSource = SelectProductClass.InitializeDGV();
            lblCustname.Text = "WALKING CUSTOMER";
            lblCustID.Text = Properties.Settings.Default["WalkingCustomerID"].ToString();
        }

        public void CalculateTotalAmt()
        {
            decimal _discount=0;
            decimal _amount=0;
            
            for (int i = 0; i < dgv.Rows.Count; ++i)
            {
                _amount += Convert.ToDecimal(dgv.Rows[i].Cells[4].Value);
            }
            decimal _toPay = _amount - _discount;

            lblAmt.Text = _amount.ToString();
            lblDiscount.Text = _discount.ToString();
            lblToPay.Text = _toPay.ToString();
            lblItems.Text = dgv.Rows.Count.ToString();

        }
        private void btnCreateCust_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            frSelectProducts f = new frSelectProducts();
            f.Show();
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CalculateTotalAmt();
        }

        private void dgv_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalculateTotalAmt();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
        
            ProcessTransaction();
            dgv.DataSource = SelectProductClass.InitializeDGV();
            button1.PerformClick();

        }

        public void ProcessTransaction()
        {

            try
            {
                using (TransactionScope trans = new TransactionScope())
               {
                    
                
                #region ORDER
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    ElectricStoreMetro.Order order = new Order();
                    order.OrderNo = lblOrderNo.Text;
                    order.TransactionDate = DateTime.Now.Date;
                    order.ClientID = 1;
                    order.TotalAmount = Convert.ToDecimal(lblAmt.Text);
                    order.SalesTax = 2;
                    order.TotalToPay = Convert.ToDecimal(lblToPay.Text);

                    db.Entry(order).State = EntityState.Added;
                    db.SaveChanges();
                }
                #endregion

                #region ITEMS
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    using (ShopDBEntities db = new ShopDBEntities())
                    {
                        ElectricStoreMetro.OrderItem oItem = new OrderItem();
                        oItem.OrderNo = lblOrderNo.Text;
                        oItem.ProductID = Convert.ToInt32(row.Cells[0].Value);
                        oItem.Quantity = Convert.ToInt32(row.Cells[2].Value);
                        oItem.PurchasePrice = Convert.ToDecimal(row.Cells[6].Value);
                        oItem.SalePrice = Convert.ToDecimal(row.Cells[5].Value);
                        oItem.TotalPrice = Convert.ToDecimal(lblAmt.Text);

                        db.Entry(oItem).State = EntityState.Added;
                        db.SaveChanges();
                    }
                }
                #endregion

                #region UPDATE QUANTITY
                foreach (DataGridViewRow row in dgv.Rows)
                {
                    using (ShopDBEntities _context = new ShopDBEntities())
                    {
                        int itemid = Convert.ToInt32(row.Cells[0].Value);
                        var item = _context.Items.SingleOrDefault(c => c.ItemID == itemid);
                        item.UsedQty = item.UsedQty + Convert.ToInt32(row.Cells[2].Value);

                        _context.Entry(item).State = EntityState.Modified;
                        _context.SaveChanges();
                    }
                }
                #endregion

                trans.Complete();
              }
                Notifications.Notfication("Success", "Thanks for shopping here", Color.Green);
                
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show("ERROR\n"+ex.Message);
                
            }
            
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            
                
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count>0)
            {
                dgv.Rows.Remove(dgv.SelectedRows[0]);
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSelectCust_Click(object sender, EventArgs e)
        {
            if (panelCust.Visible)
            {
                panelCust.Visible = false;
                panelCust.SendToBack();
            }
            else
            {

                using (ShopDBEntities _context = new ShopDBEntities())
                {
                    var s = (from u in _context.Customers select u).ToList();
                    dgvCustomer.DataSource = s;
                }

            panelCust.Visible = true;
            panelCust.BringToFront();
            }
            
        }

        private void dgvCustomer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgvCustomer.Rows[e.RowIndex];

                lblCustID.Text = row.Cells[0].Value.ToString();
                lblCustname.Text = row.Cells[1].Value.ToString();
                lblCustAddress.Text = row.Cells[3].Value.ToString();
                lblCustCell.Text = row.Cells[2].Value.ToString();

                this.panelCust.Visible = false;
                this.panelCust.SendToBack();
            }
        }
        private string GenerateOrderNo()
        {
            string orderNo="";
            Random rnd = new Random();
            long orderPart1 = rnd.Next(100000, 9999999);
            long orderPart2 = rnd.Next(1000, 9999);
            orderNo = "DS-" + orderPart1 + "-" + orderPart2;
            return orderNo;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //insertTestItems();
            bool isAlreadyExist = true;
            
            while (isAlreadyExist)
            {
                string orderNo;
                orderNo = GenerateOrderNo();
                isAlreadyExist = CheckOrderExistance(orderNo);
                lblOrderNo.Text = orderNo;
            }
            
        }

        private bool CheckOrderExistance(string orderNo)
        {
            bool orderNoExist = false;

            using (var con = new SqlConnection(DBConnection.cn))
            {

                string query = "SELECT * FROM ORDERS WHERE OrderNo=@orderNo";
                using (var cmd = new SqlCommand(query, con))
                {
                    DataTable dtAnyData = new DataTable();
                    con.Open();
                    cmd.Parameters.AddWithValue("@orderNo", orderNo);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAnyData.Load(reader);
                    if (dtAnyData.Rows.Count>0)
                    {
                        orderNoExist = true;
                    }
                }
                

            }

            return orderNoExist;
        }

        private void ReceiptDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font HeaderFont = new Font("Courier New", 20, FontStyle.Regular);
            Font font = new Font("Courier New", 8, FontStyle.Regular);
            int item = 10;
            int qty = item+110;
            int price = qty+50;
            int amount = price+50;
            int yPos = 270;

            string dash = "=================================";

            e.Graphics.DrawString(dash, font, Brushes.Black, new Point(10, 250));
            e.Graphics.DrawString(dash, font, Brushes.Black, new Point(10, 230));
           

            //Image img = Resources.accounts;
            //e.Graphics.DrawImage(img, 400, 2, img.Width, img.Height);
            DataSet ds = SelectProductClass.Select();
            string name = ds.Tables[0].Rows[0]["Name"].ToString();
                e.Graphics.DrawString(name, HeaderFont, Brushes.Black, new Point(10, 50));
            
            e.Graphics.DrawString("Date: " + DateTime.Now, font, Brushes.Black, new Point(10,200));

            e.Graphics.DrawString("Client Name " + lblCustname.Text, font, Brushes.Black, new Point(10, 220));
            

            e.Graphics.DrawString("ITEM ", font, Brushes.Black, new Point(item, 240));
            e.Graphics.DrawString("QTY ", font, Brushes.Black, new Point(qty, 240));
            e.Graphics.DrawString("PRICE ", font, Brushes.Black, new Point(price, 240));
            e.Graphics.DrawString("AMOUNT ", font, Brushes.Black, new Point(amount, 240));

            
            
            
            //foreach(var i in dgv.Rows)
            //{
            //    e.Graphics.DrawString(i., new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(350, 240));
            //}
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                e.Graphics.DrawString(dgv.Rows[i].Cells[1].Value.ToString(), font, Brushes.Black, new Point(item, yPos));
                e.Graphics.DrawString(dgv.Rows[i].Cells[2].Value.ToString(), font, Brushes.Black, new Point(qty, yPos));
                e.Graphics.DrawString(dgv.Rows[i].Cells[3].Value.ToString(), font, Brushes.Black, new Point(price, yPos));
                e.Graphics.DrawString(dgv.Rows[i].Cells[4].Value.ToString(), font, Brushes.Black, new Point(amount, yPos));
                
                yPos += 20;
            }

            e.Graphics.DrawString(dash, font, Brushes.Black, new Point(item, yPos + 10));

            e.Graphics.DrawString("Total Items: "+lblItems.Text, font, Brushes.Black, new Point(item, yPos+20));
            e.Graphics.DrawString("Total Amount: " + lblAmt.Text, font, Brushes.Black, new Point(item, yPos+40));
            e.Graphics.DrawString("Total To Pay: " + lblToPay.Text, font, Brushes.Black, new Point(item, yPos + 60));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceiptPreviewDialog.Document = ReceiptDocument;
            ReceiptPreviewDialog.Show();
        }
    }
}
//=500 - (10/100 * 500)