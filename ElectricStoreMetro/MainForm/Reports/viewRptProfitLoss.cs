using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Reports
{
    public partial class viewRptProfitLoss : Form
    {
        public viewRptProfitLoss()
        {
            InitializeComponent();
        }
        public DataSet dsBusinessInfo = new DataSet();
        public DataSet dsProfitLoss = new DataSet();

        private void viewRptProfitLoss_Load(object sender, EventArgs e)
        {
            decimal saleprice = Convert.ToDecimal(txtTotalSP.Text);
            decimal purchaseprice = Convert.ToDecimal(txtTotalPP.Text);
            decimal discount = Convert.ToDecimal(txtDiscountGiven.Text);

            txtCashInHand.Text = (saleprice - purchaseprice - discount).ToString();
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Properties.Settings.Default["ReportSavePath"].ToString() + "Shop Management Profilt and Loss report.jpg";
                Bitmap bitmap = new Bitmap(this.Width, this.Height);
                DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(path, ImageFormat.Jpeg);
                MessageBox.Show("Report saved on the following path\n" + path, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\n" + ex.Message, "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }

        private void txtReportFooter_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }
    }
}
