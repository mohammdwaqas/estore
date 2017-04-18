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

namespace ElectricStoreMetro.MainForm.Customer
{
    public partial class frCustomer : MetroFramework.Forms.MetroForm
    {
        public frCustomer()
        {
            InitializeComponent();
        }
        
        private void frCustomer_Load(object sender, EventArgs e)
        {
            initialize();
        }

        private void initialize()
        {
            txtAddress.Clear(); txtContact.Clear(); txtName.Clear();
            txtSearch.Clear(); txtName.Focus();
            using (ShopDBEntities _context = new ShopDBEntities())
            {
                var s = (from u in _context.Customers select u).ToList();
                dgv.DataSource = s;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (ShopDBEntities _context = new ShopDBEntities())
            {
                ElectricStoreMetro.Customer cust = new ElectricStoreMetro.Customer();
                cust.Name = txtName.Text;
                cust.Address = txtAddress.Text;
                cust.Cell = txtContact.Text;
                cust.Date = DateTime.Now;

                _context.Entry(cust).State = EntityState.Added;

                _context.SaveChanges();
                Notifications.Notfication("New Customer created", "Welcome " + txtName.Text, Color.Green);
                initialize();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopDBEntities _context = new ShopDBEntities())
            {
                
                //ElectricStoreMetro.Customer cust = new ElectricStoreMetro.Customer();
                var cust = _context.Customers.FirstOrDefault(c => c.CustID == updateID);
                cust.Name = txtName.Text;
                cust.Address = txtAddress.Text;
                cust.Cell = txtContact.Text;
                cust.Date = DateTime.Now;

                _context.Entry(cust).State = EntityState.Modified;

                _context.SaveChanges();
                Notifications.Notfication("Customer Updated", "Customer updated", Color.Green);
                initialize();

            }
        }
        int updateID=0;
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];

                updateID   = Convert.ToInt32(row.Cells[0].Value.ToString());
                txtName.Text = row.Cells[1].Value.ToString();
                txtContact.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
            
            }
        }
    }
}
