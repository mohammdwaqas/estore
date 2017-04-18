using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Sale
{
    public partial class frModifySales : Form
    {
        public frModifySales()
        {
            InitializeComponent();
        }
        public DataSet productDataset = new DataSet();
        private void frModifySales_Load(object sender, EventArgs e)
        {
            dgv.DataSource = productDataset.Tables[0].DefaultView;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //frSales f = new frSales();
            ModifyProductClass.CustomerID = Convert.ToInt32(lblCsutomerID.Text);
            ModifyProductClass.CustomerName = lblCustomerName.Text;
            ModifyProductClass.OrderNo = lblOrderNo.Text;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form f = (Application.OpenForms["frSales"]);
            if(f!=null)
            {
                MessageBox.Show("Form Opened");
            }
            else{
                MessageBox.Show("Not opened");
            }
        }
    }
}
