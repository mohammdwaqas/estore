using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Measurement
{
    public partial class frMeasurement : Form
    {
        public frMeasurement()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                switch(txtMeasureInput.Text)
                {
                    case "Yards":
                        txtYard.Text = Convert.ToDecimal(txtValue.Text).ToString();
                        txtFoot.Text = (Convert.ToDecimal(txtValue.Text) * 3).ToString();
                        //txtFoot.Text = (Convert.ToDecimal(txtValue.Text) * 3 * 12).ToString();
                        txtMeters.Text = (Convert.ToDecimal(txtValue.Text) * Convert.ToDecimal( 0.9144)).ToString();
                        break;
                    case "meter":
                        txtMeters.Text = Convert.ToDecimal(txtValue.Text).ToString();
                        txtYard.Text = (Convert.ToDecimal(txtValue.Text) * Convert.ToDecimal(1.09361)).ToString();
                        txtFoot.Text = (Convert.ToDecimal(txtValue.Text) * Convert.ToDecimal(3.28084)).ToString();
                        break;
                    case "foot":
                        txtFoot.Text = Convert.ToDecimal(txtValue.Text).ToString();
                        txtMeters.Text = (Convert.ToDecimal(txtValue.Text) * Convert.ToDecimal(0.3048)).ToString();
                        txtYard.Text = (Convert.ToDecimal(txtValue.Text) * Convert.ToDecimal(0.333333)).ToString();
                        break;
                   // case "Feet":
                        
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
