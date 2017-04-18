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

namespace ElectricStoreMetro.MainForm.Product
{
    public partial class frProducts : Form
    {
        public frProducts()
        {
            InitializeComponent();
        }

        private void frProducts_Load(object sender, EventArgs e)
        {
            //GET CATEGORIES FROM DB
            PopulateDropDown();

            //GET ITEMS FROM DB
            PopulateDGV();
            

            //GET MEASUREMENTS FROM DB
            PopulateUnits();
           
            //SET MAX VALUE FOR NUMERIC UPDOWN
            numValue.Maximum = decimal.MaxValue;
        }

        private void PopulateUnits()
        {
            cboUnit.DataSource = ProductClass.PopulateMeasurementDropDown().Tables[0].DefaultView;
            cboUnit.DisplayMember = "Name";
            cboUnit.ValueMember = "MeasurementID";
        }

        private void PopulateDropDown()
        {
            cboCat.DataSource = ProductClass.PopulateDropDown().Tables[0].DefaultView;
            cboCat.DisplayMember = "Name";
            cboCat.ValueMember = "CatID";
        }
        private void PopulateDGV()
        {
            dgv.DataSource = ProductClass.SelectProducts().Tables[0].DefaultView;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (isValidateOK())
            {
                try
                {
                    #               region INSERT
                    using(ShopDBEntities db = new ShopDBEntities())
                    {
                        ElectricStoreMetro.Item iProduct = new Item();
                        iProduct.Name=txtItemName.Text.Trim();
                        iProduct.PurchasePrice=Convert.ToDecimal(txtPurchasePrice.Text);
                        iProduct.MeasurementID=Convert.ToInt32(cboUnit.SelectedValue);
                        iProduct.Qty=Convert.ToInt32(numValue.Value);
                        iProduct.UsedQty=0;
                        iProduct.Description=txtDescription.Text;
                        iProduct.CatID=Convert.ToInt32(cboCat.SelectedValue);
                        iProduct.Saleprice=Convert.ToDecimal(txtSalePrice.Text);
                        iProduct.DiscountPercent=0;
                        iProduct.DateCreated=DateTime.Now.Date;
                        iProduct.DateUpdated=DateTime.Now.Date;
                        iProduct.UserID=5;

                        db.Entry(iProduct).State=EntityState.Added;
                        db.SaveChanges();
                    }
                #endregion

                    #region SUCCESS MESSAGE
                    Notifications.Notfication(txtItemName.Text + " Saved.",
                        "Item Name: "+txtItemName.Text + " \nQuantity / Value: "+numValue.Value.ToString() + " "+ cboUnit.Text +
                        " \nPurchase Price: "+ txtPurchasePrice.Text + " \nSale Price: "+txtSalePrice.Text
                        + "\nSaved in the system.", Color.Green);
                    #endregion

                    ResetForm(); //Gets form ready for new product
                    PopulateDGV();
                }
                catch (Exception ex)
                {
                    throw;
                    MessageBox.Show("Error while inserting new stock. see the message below for details.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Validation Error");
            }
        }
        private bool isValidateOK()
        {
            bool validated = false;

            if(txtItemName.Text.Trim()==string.Empty ||
                txtPurchasePrice.Text.Trim()==string.Empty ||
                cboCat.SelectedIndex<0 ||
                cboUnit.SelectedIndex <0 ||
                numValue.Value==null ||
                 numValue.Value <= 0 ||
                Convert.ToDecimal(txtPurchasePrice.Text.Trim()) == 0)
            {
                validated = false;
            }
            else
            {
                validated = true;
            }
            return validated;
        }
        private void ResetForm()
        {
            txtItemName.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtPurchasePrice.Text = "0";
            txtSalePrice.Text = "0";
            numValue.Value = 0;
            txtItemName.Focus();

        }
        
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex > -1)
           {
               DataGridViewRow row = this.dgv.Rows[e.RowIndex];
               txtItemName.Text = row.Cells["Item Name"].Value.ToString();
               txtPurchasePrice.Text = row.Cells["PurchasePrice"].Value.ToString();
               txtSalePrice.Text = row.Cells["Saleprice"].Value.ToString();
               txtDescription.Text = row.Cells["Description"].Value.ToString();

               if (cboCat.DataSource == null)
                   PopulateDropDown();

               cboCat.SelectedValue = row.Cells["CatID"].Value.ToString();
               if (cboUnit.DataSource == null)
                   PopulateUnits();
               cboUnit.SelectedValue = Convert.ToInt32(row.Cells["MeasurementID"].Value.ToString());
               
               numValue.Value = Convert.ToDecimal(row.Cells["Qty"].Value);
               lblID.Text = row.Cells["ItemID"].Value.ToString();
           }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                #region UPDATE
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    int UpdateID = Convert.ToInt32(lblID.Text);
                    var _item = db.Items.FirstOrDefault(c => c.ItemID==UpdateID);
                       
                        _item.Name=txtItemName.Text.Trim();
                        _item.PurchasePrice=Convert.ToDecimal(txtPurchasePrice.Text);
                        _item.MeasurementID=Convert.ToInt32(cboUnit.SelectedValue);
                        _item.Qty=Convert.ToInt32(numValue.Value);
                        _item.Description=txtDescription.Text;
                        _item.CatID=Convert.ToInt32(cboCat.SelectedValue);
                        _item.Saleprice=Convert.ToDecimal(txtSalePrice.Text);

                    db.Entry(_item).State=EntityState.Modified;
                    db.SaveChanges();
                }
                #endregion
                #region SUCCESS MESSAGE
                Notifications.Notfication(txtItemName.Text + " updated.",
                        "Item Name: " + txtItemName.Text + " \nQuantity / Value: " + numValue.Value.ToString() + " " + cboUnit.Text +
                        " \nPurchase Price: " + txtPurchasePrice.Text + " \nSale Price: " + txtSalePrice.Text
                        + "\nUpdated in the system.", Color.Green);
                #endregion
                ResetForm(); //Gets form ready for new product
                PopulateDGV();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error while updating information.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                #region DELETE
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    int updateid=Convert.ToInt32(lblID.Text);
                    var _instance = db.Items.FirstOrDefault(c => c.ItemID == updateid);
                        db.Entry(_instance).State=EntityState.Deleted;
                    db.SaveChanges();
                }
                #endregion
                Notifications.Notfication("Delted successfully.", "1 Item removed from the system.", Color.Green);
               ResetForm(); //Gets form ready for new product
                PopulateDGV();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Error while deleting information.\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
