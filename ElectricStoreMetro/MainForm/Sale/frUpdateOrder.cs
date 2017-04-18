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
using System.Transactions;
using ElectricStoreMetro.MainForm.Category;
using ElectricStoreMetro.MainForm.Product;
using ElectricStoreMetro.MainForm.Accounts;
using ElectricStoreMetro.MainForm.Return;

namespace ElectricStoreMetro.MainForm.Sale
{
    public partial class frUpdateOrder : Form
    {
        public frUpdateOrder()
        {
            InitializeComponent();
        }

        private void btnFetchOrder_Click(object sender, EventArgs e)
        {
            DataSet returnDs = SelectProductClass.SelectItemsForReturn(txtOrderNo.Text);
            dgv.DataSource = returnDs.Tables[0].DefaultView;

            DataSet returnOrderDs = SelectProductClass.SelectOrderForReturn(txtOrderNo.Text);

            //GRAND TOTAL, TOTAL TO PAY
            //txtGrandTotal.Text = returnOrderDs.Tables[0].Rows[0][2].ToString();
            lblTotalToPay.Text = returnOrderDs.Tables[0].Rows[0][2].ToString();

           

            //DISCOUNT
            txtDiscount.Text = returnOrderDs.Tables[0].Rows[0][4].ToString();

            //TOTAL PAYMENT
            txtTotalPayment.Text = returnOrderDs.Tables[0].Rows[0][5].ToString();

            //PAYMENT DUE
            txtPaymentDue.Text = returnOrderDs.Tables[0].Rows[0][6].ToString();



        }

        private void txtTotalPayment_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTotalPayment.Text == "0" || Convert.ToDecimal(txtTotalPayment.Text) == 0)
                {
                    txtTotalPayment.Text = "0";
                }
                Total();
            }
            catch
            {


            }
        }
        private void Total()
        {
            decimal _totalPayment = Convert.ToDecimal(txtTotalPayment.Text);
            decimal _paymentDue = Convert.ToDecimal(txtPaymentDue.Text);
            decimal _totalToPay = Convert.ToDecimal(lblTotalToPay.Text);
            //decimal _paymentDue = Convert.ToDecimal(txtPaymentDue.Text);

            _paymentDue = _totalToPay - _totalPayment; txtPaymentDue.Text = _paymentDue.ToString();



            
        }

        private void brnProcess_Click(object sender, EventArgs e)
        {
            try
            {
                int CompleteOStatusID = Convert.ToInt32(Properties.Settings.Default["CompleteOStatusID"]);
                int PendingOStatusID = Convert.ToInt32(Properties.Settings.Default["PendingOStatusID"]);
                
                    using (ShopDBEntities db = new ShopDBEntities())
                    {
                        string prderNo = txtOrderNo.Text;
                        var toUpdate = db.Orders.SingleOrDefault(c => c.OrderNo == prderNo);
                        toUpdate.TotalPayment = Convert.ToDecimal(txtTotalPayment.Text);
                        toUpdate.PaymentDue = Convert.ToDecimal(txtPaymentDue.Text);
                        if (Convert.ToDecimal(txtPaymentDue.Text) == 0)
                        {
                            toUpdate.OrderStatusID = CompleteOStatusID;
                        }
                        else
                        {
                            toUpdate.OrderStatusID = PendingOStatusID;
                        }
                        db.Entry(toUpdate).State = EntityState.Modified;
                        db.SaveChanges();
                        MessageBox.Show("Updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                     
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                txtOrderNo.Focus();
            }
        }

        private void frUpdateOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnCreateProductCategories_Click(object sender, EventArgs e)
        {
            frCategory cat = new frCategory();
            cat.ShowDialog();
        }

        private void btnCreateNewProduct_Click(object sender, EventArgs e)
        {
            frProduct product = new frProduct();
            product.ShowDialog();
        }

        private void btnCreateUserAccount_Click(object sender, EventArgs e)
        {
            frAccount acc = new frAccount();
            acc.ShowDialog();

        }

        private void btnCreateNewSale_Click(object sender, EventArgs e)
        {
            frSales s = new frSales();
            s.ShowDialog();

        }

        private void btnReturnTransaction_Click(object sender, EventArgs e)
        {
            frReturn r = new frReturn();
            r.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
