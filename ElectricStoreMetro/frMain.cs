using ElectricStoreMetro.MainForm.Accounts;
using ElectricStoreMetro.MainForm.Backup_Restore;
using ElectricStoreMetro.MainForm.Category;
using ElectricStoreMetro.MainForm.Contact;
using ElectricStoreMetro.MainForm.Customer;
using ElectricStoreMetro.MainForm.Log;
using ElectricStoreMetro.MainForm.Product;
using ElectricStoreMetro.MainForm.Reports;
using ElectricStoreMetro.MainForm.Return;
using ElectricStoreMetro.MainForm.Sale;
using ElectricStoreMetro.MainForm.Settings;
using ElectricStoreMetro.MainForm.Shop;
using ElectricStoreMetro.MainForm.Stock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro
{
    public partial class frMain : MetroFramework.Forms.MetroForm
    {
        public frMain()
        {
            InitializeComponent();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            frAccount account = new frAccount();
            account.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            frBackup backup = new frBackup();
            backup.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            frSales sale = new frSales();
            //sale.MdiParent = this;
            sale.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            frCategory f = new frCategory();
            f.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            frCustomer cust = new frCustomer();
            cust.Show();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            frLog f = new frLog();
            //f.MdiParent = this; 
            f.Show();
        }


        private void metroTile6_Click(object sender, EventArgs e)
        {
            frProduct f = new frProduct();
            f.Show();
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            frStock f = new frStock();
            f.Show();
            
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            frParamMonthly f = new frParamMonthly();
            //f.MdiParent = this; 
            f.Show();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
           
        }

        private void frMain_Load(object sender, EventArgs e)
        {

        }

        private void shopSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frShopSetup f = new frShopSetup();
            f.Show();
        }

        private void productCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCategory f = new frCategory();
            f.Show();
        }

        private void stockManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frStock f = new frStock();
            f.Show();
        }

        private void createStockProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frProduct f = new frProduct();
            f.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createSystemUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frAccount account = new frAccount();
            account.Show();
        }

        private void createNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frCustomer cust = new frCustomer();
            cust.Show();
        }

        private void newCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frSales sale = new frSales();
            //sale.MdiParent = this;
            sale.Show();
        }

        private void backupResetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frBackup backup = new frBackup();
            //backup.ShowDialog();
            frBAckupRestore backup = new frBAckupRestore();
            backup.ShowDialog();
        }

        private void viewReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frParamMonthly f = new frParamMonthly();
            //f.MdiParent = this; 
            f.Show();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frSettings settings = new frSettings();
            settings.ShowDialog();
        }

        private void contactDeveloperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frContact contact = new frContact();
            contact.ShowDialog();
        }

        private void updatePreviousOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frUpdateOrder fr = new frUpdateOrder();
            fr.Show();

        }

        private void returnItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frReturn r = new frReturn();
            r.Show();
        }
    }
}
