using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Reports
{
    public partial class frViewSales : Form
    {
        public frViewSales()
        {
            InitializeComponent();
        }
        DataSet dsAllSales=new DataSet();
        private void btnLoad_Click(object sender, EventArgs e)
        {
            //var clss = new ViewSalesClass();
            //dsAllSales = clss.ViewAllSales();
            //dgv.DataSource = dsAllSales.Tables[0].DefaultView;
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                ElectricStoreMetro.MainForm.Sale.frModifySales fr = new Sale.frModifySales();
                fr.lblOrderNo.Text = row.Cells["OrderNo"].Value.ToString();
                fr.lblTotalAmount.Text = row.Cells["TotalAmount"].Value.ToString();
                fr.lblSalesTax.Text = row.Cells["SalesTax"].Value.ToString();
                fr.lblTotalPayment.Text = row.Cells["TotalPayment"].Value.ToString();
                fr.lblDiscount.Text = row.Cells["Discount"].Value.ToString();
                fr.lblTotalToPay.Text = row.Cells["TotalToPay"].Value.ToString();
                fr.lblPaymentDue.Text=row.Cells["PaymentDue"].Value.ToString();
                fr.lblStatus.Text = row.Cells["Name"].Value.ToString();


                DataSet ds = ElectricStoreMetro.MainForm.Sale.SelectProductClass.SelectProductsByOrderNo(row.Cells["OrderNo"].Value.ToString());
                int custid = Convert.ToInt32(row.Cells["ClientID"].Value);
               
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    var name = db.Customers.Where(c => c.CustID == custid).Select(c => c.Name).SingleOrDefault();
                    fr.lblCsutomerID.Text = custid.ToString();
                    fr.lblCustomerName.Text = name.ToString();
                }
                fr.productDataset = ds;
                
                fr.ShowDialog();
            }
        }
    }
}
