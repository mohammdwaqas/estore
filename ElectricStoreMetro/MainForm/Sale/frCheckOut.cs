using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace ElectricStoreMetro.MainForm.Sale
{
    public partial class frCheckOut : MetroFramework.Forms.MetroForm
    {
        public frCheckOut()
        {
            InitializeComponent();
        }
       public string amount;
        private void frCheckOut_Load(object sender, EventArgs e)
        {


            txtAmountDue.Text = amount;
        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void txtAmountGiven_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal amtDue = Convert.ToDecimal(txtAmountDue.Text);
                decimal amtGiven = Convert.ToDecimal(txtAmountGiven.Text);
                decimal change =  amtGiven - amtDue;

                txtChange.Text = change.ToString();
               

                
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message);
                
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            frSale f = new frSale();
            //f.ProcessTransaction();
            //f.dgv.Rows.Clear();
            
            this.Close();
        }
    }
}
