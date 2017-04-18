using ElectricStoreProject.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreProject
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            frAddProduct f = new frAddProduct(); f.ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            frStock f = new frStock();
            f.ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            frSale f = new frSale();
            f.ShowDialog();
        }
    }
}
