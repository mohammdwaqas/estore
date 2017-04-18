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
using System.Data.Entity;

namespace ElectricStoreMetro.MainForm.Product
{
    public partial class frProduct : MetroFramework.Forms.MetroForm
    {
        public frProduct()
        {
            InitializeComponent();
        }

        private void frProduct_Load(object sender, EventArgs e)
        {
            initiate();
        }

        private void initiate()
        {
            //dgv.DataSource = ProductClass.Select().Tables[0].DefaultView;
            dgv.DataSource = null;


            ShopDBEntities _context = new ShopDBEntities();
            _context.Configuration.ProxyCreationEnabled = false;
            dgv.DataSource = (from u in _context.Items select u).ToList();


            tbName.Clear();
            tbDesc.Clear();
            numQty.Value = 0;
            numDPercent.Value = 0;
            txtPPrice.Text = "0";
            txtSPrice.Text = "0";
            cbCat.SelectedIndex = -1;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text.Trim())
                || cbCat.SelectedIndex == -1
                //|| numQty.Value == 0
                )
            {
                MetroMessageBox.Show(this, "Validation Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //ProductClass.Create(tbName.Text.Trim(), Convert.ToInt32(cbCat.SelectedValue.ToString()), 5, tbDesc.Text, Convert.ToInt32(numQty.Value), 0, DateTime.Now, DateTime.Now);

                //insert into db
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    ElectricStoreMetro.Item item = new Item();
                    item.Name = tbName.Text.Trim();
                    item.Description = tbDesc.Text.Trim();
                    item.CatID = Convert.ToInt32(cbCat.SelectedValue);
                    item.PurchasePrice = Convert.ToInt32(txtPPrice.Text);
                    item.Saleprice = Convert.ToInt32(txtSPrice.Text);
                    item.DiscountPercent = Convert.ToInt32(numDPercent.Value);
                    // item.Qty = Convert.ToInt32(numQty.Value ? 0 : numQty.Value);
                    item.Qty = Convert.ToInt32(numQty.Value);
                    item.UsedQty = 0;

                    item.UserID = 5;
                    item.DateCreated = DateTime.Now;
                    item.DateUpdated = DateTime.Now;

                    db.Entry(item).State = EntityState.Added;
                    db.SaveChanges();
                }
                Notifications.Notfication("New Item Saved", "Item " + tbName.Text + " saved in the system", Color.Green);
                initiate();
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {

        }

        private void frProduct_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void cbCat_Click(object sender, EventArgs e)
        {
            PopulateDropDown();
        }

        private void PopulateDropDown()
        {
            try
            {
                cbCat.DataSource = ProductClass.PopulateDropDown().Tables[0].DefaultView;
                cbCat.DisplayMember = "Name";
                cbCat.ValueMember = "CatID";
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, "Error while getting category list\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int updateID;
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];

                updateID = Convert.ToInt32(row.Cells[0].Value.ToString());
                using (ShopDBEntities _context = new ShopDBEntities())
                {
                    if (cbCat.DataSource==null)
                        PopulateDropDown();
                    
                    var item = _context.Items.SingleOrDefault(c => c.ItemID == updateID);
                    tbName.Text = item.Name;
                    tbDesc.Text = item.Description;
                    cbCat.SelectedValue = item.CatID;
                    txtPPrice.Text = item.PurchasePrice.ToString();
                    txtSPrice.Text = item.Saleprice.ToString();
                    numQty.Value = item.Qty;
                    numDPercent.Value = Convert.ToDecimal(item.DiscountPercent);


                }
            }


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (ShopDBEntities _context = new ShopDBEntities())
                {
                    var item = _context.Items.SingleOrDefault(c => c.ItemID == updateID);
                    item.Name = tbName.Text;
                    item.Description = tbDesc.Text;
                    item.CatID = Convert.ToInt32(cbCat.SelectedValue);
                    item.PurchasePrice = Convert.ToDecimal(txtPPrice.Text);
                    item.Saleprice = Convert.ToDecimal(txtSPrice.Text);
                    item.DiscountPercent = Convert.ToInt32(numDPercent.Value);
                    item.Qty = Convert.ToInt32(numQty.Value);
                    item.UserID = 5;
                    item.DateUpdated = DateTime.Now;

                    _context.Entry(item).State = EntityState.Modified;
                    _context.SaveChanges();
                    Notifications.Notfication("Item Updated successfully!", tbName.Text + " updated successfully", Color.Green);
                    initiate();
                    //MessageBox.Show("updated");
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please select Item to update and try again.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
           
            }
        }

        private void txtPPrice_Click(object sender, EventArgs e)
        {

        }

        private void txtPPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPPrice.Text))
                txtPPrice.Text = "0";
        }

        private void txtSPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSPrice.Text))
                txtSPrice.Text = "0";
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            for (int i = 0; i < dgv.Rows.Count; i++)
            {
                list.Add(dgv.Rows[i].Cells[0].Value.ToString());
            }
            var l=  string.Join(",", list);
            MessageBox.Show(l);
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                using (ShopDBEntities _context = new ShopDBEntities())
                {
                    var item = _context.Items.SingleOrDefault(c => c.ItemID == updateID);
                    _context.Items.Remove(item);
                    _context.Entry(item).State = EntityState.Deleted;
                    try
                    {
                        _context.SaveChanges();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                        return;
                    }

                    Notifications.Notfication("Deleted successfully!", tbName.Text + " deleted successfully.", Color.Green);
                    initiate();
                }
            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Please select Item to update and try again.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
               
            }
        }
    }
}
