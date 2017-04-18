using ElectricStoreProject.Forms.SubForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreProject.Forms
{
    public partial class frSale : Form
    {
        public frSale()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frSaleSummary fr = new frSaleSummary();
            fr.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frDailySale f = new frDailySale();
            f.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            frMontlySale f = new frMontlySale();
            f.ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            frAnnualSale f = new frAnnualSale();
            f.ShowDialog();
        }
    }
}
