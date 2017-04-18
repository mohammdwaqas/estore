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

namespace ElectricStoreMetro.MainForm.Shop
{
    public partial class frShopSetup : MetroFramework.Forms.MetroForm
    {
        public frShopSetup()
        {
            InitializeComponent();
        }

        private void frShopSetup_Load(object sender, EventArgs e)
        {

        }

      private void initiate()
        {
            txtContact.Clear();
            txtName.Clear();
            txtSlogan.Clear();
            txtAbout.Clear();
            txtAddress.Clear();
            txtHeader.Clear();
            txtFooter.Clear();
         
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                CompanySetup setup = new CompanySetup();
                setup.Name = txtName.Text.Trim();
                setup.Address = txtAddress.Text.Trim();
                setup.Contact = txtContact.Text.Trim();
                setup.ReportFooter = txtFooter.Text.Trim();
                setup.ReportHeader = txtHeader.Text.Trim();
                setup.Slogan = txtSlogan.Text.Trim();
                setup.About = txtAbout.Text.Trim();

                db.CompanySetups.Add(setup);
                db.Entry(setup).State = EntityState.Added;
                db.SaveChanges();

                Notifications.Notfication
                    ("Setup saved", "Setup for " + txtName + " saved in the system.", Color.Green);
                initiate();
            }
        }

        private void btnShowPrevious_Click(object sender, EventArgs e)
        {
            showPreviousInfo();
        }

        private void showPreviousInfo()
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                var setup = db.CompanySetups.SingleOrDefault();
                txtName.Text = setup.Name;
                txtAddress.Text = setup.Address;
                txtAbout.Text = setup.About;
                txtContact.Text = setup.Contact;
                txtFooter.Text = setup.ReportFooter;
                txtHeader.Text = setup.ReportHeader;
                txtSlogan.Text = setup.Slogan;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                //CompanySetup setup = new CompanySetup();
                var setup = db.CompanySetups.SingleOrDefault();
                setup.Name = txtName.Text.Trim();
                setup.Address = txtAddress.Text.Trim();
                setup.Contact = txtContact.Text.Trim();
                setup.ReportFooter = txtFooter.Text.Trim();
                setup.ReportHeader = txtHeader.Text.Trim();
                setup.Slogan = txtSlogan.Text.Trim();
                setup.About = txtAbout.Text.Trim();

                db.CompanySetups.Add(setup);
                db.Entry(setup).State = EntityState.Modified;
                db.SaveChanges();

                Notifications.Notfication
                    ("Setup saved", "Setup for " + txtName.Text + " saved in the system.", Color.Green);
                //initiate();
                showPreviousInfo();
            
            }
        }
    }
}
