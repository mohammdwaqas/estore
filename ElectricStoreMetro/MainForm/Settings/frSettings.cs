using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Settings
{
    public partial class frSettings : Form
    {
        public frSettings()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (txtReportSavePath.Text.Trim() == string.Empty || txtStockLimit.Text.Trim() == string.Empty || txtCompleteID.Text.Trim() == string.Empty || txtCustID.Text.Trim() == string.Empty || txtPendingID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Null values are not accepted. please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                SetValues();
                GetValues();
            }
        }
        private void GetValues()
        {
            try
            {
                //GENERAL SETINGS
                txtCustID.Text = Properties.Settings.Default["WalkingCustomerID"].ToString();
                txtCompleteID.Text = Properties.Settings.Default["CompleteOStatusID"].ToString();
                txtPendingID.Text = Properties.Settings.Default["PendingOStatusID"].ToString();
                txtStockLimit.Text = Properties.Settings.Default["MinStock"].ToString();
                txtReportSavePath.Text = Properties.Settings.Default["ReportSavePath"].ToString();

                //MEASUREMENT SETTINGS
                //METER
                txtMeterMeter.Text = Properties.Settings.Default.metertometer.ToString();
                txtYardMeter.Text = Properties.Settings.Default.yardtometer.ToString();
                txtFootMeter.Text = Properties.Settings.Default.foottometer.ToString();

                //FOOT
                txtMeterFoot.Text = Properties.Settings.Default.metertofoot.ToString();
                txtYardFoot.Text = Properties.Settings.Default.yardtofoot.ToString();
                txtFootFoot.Text = Properties.Settings.Default.foottofoot.ToString();

                //YARD
                //meter,yard,foot
                txtMeterYard.Text = Properties.Settings.Default.metertoyard.ToString();
                txtFootYard.Text = Properties.Settings.Default.foottoyard.ToString();
                txtYardYard.Text = Properties.Settings.Default.yardtoyard.ToString();

                //FOOT>KG
                txtFootKg.Text = Properties.Settings.Default.foottokg.ToString();
                txtKGtoKG.Text = Properties.Settings.Default.kgtokg.ToString();
                

     
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while getting previous values from database.\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void SetValues()
        {
            try
            {
                 Properties.Settings.Default["WalkingCustomerID"] = Convert.ToInt32(txtCustID.Text);
                 Properties.Settings.Default["CompleteOStatusID"]=Convert.ToInt32(txtCompleteID.Text);
                 Properties.Settings.Default["PendingOStatusID"]=Convert.ToInt32(txtPendingID.Text);
                 Properties.Settings.Default["MinStock"] = Convert.ToInt32(txtStockLimit.Text.Trim());
                 Properties.Settings.Default["ReportSavePath"] =txtReportSavePath.Text;


                 //MEASUREMENT SETTINGS
                 //METER
                  Properties.Settings.Default.metertometer=Convert.ToDecimal(txtMeterMeter.Text);
                  Properties.Settings.Default.yardtometer = Convert.ToDecimal(txtYardMeter.Text);
                  Properties.Settings.Default.foottometer = Convert.ToDecimal(txtFootMeter.Text);

                 //FOOT
                  Properties.Settings.Default.metertofoot = Convert.ToDecimal(txtMeterFoot.Text);
                  Properties.Settings.Default.yardtofoot = Convert.ToDecimal(txtYardFoot.Text);
                  Properties.Settings.Default.foottofoot = Convert.ToDecimal(txtFootFoot.Text);

                 //YARD
                  Properties.Settings.Default.metertoyard = Convert.ToDecimal(txtMeterYard.Text);
                  Properties.Settings.Default.foottoyard = Convert.ToDecimal(txtFootYard.Text);
                  Properties.Settings.Default.yardtoyard = Convert.ToDecimal(txtYardYard.Text);

                //FOOT > KG
                  Properties.Settings.Default.foottokg = Convert.ToDecimal(txtFootKg.Text);
                  Properties.Settings.Default.kgtokg = Convert.ToDecimal(txtKGtoKG.Text);


                 Properties.Settings.Default.Save();

                 DialogResult question= MessageBox.Show("Settings saved successfully. Close the form now?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
              if (question==DialogResult.Yes)
              {
                 this.Close();
              }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while saving value in settings.\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void frSettings_Load(object sender, EventArgs e)
        {
            GetValues();
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
