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

namespace ElectricStoreMetro.MainForm.Category
{
    public partial class frCategory : MetroFramework.Forms.MetroForm
    {
        public frCategory()
        {
            InitializeComponent();
        }

        private void frCategory_Load(object sender, EventArgs e)
        {
            InitiateControls();
            
        }

        private void InitiateControls()
        {
            tbDesc.Clear();
            tbName.Clear();
            dgv.DataSource = CategoryClass.Select().Tables[0].DefaultView;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Please Enter Category Name to continue..", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               // CategoryClass.Create(tbName.Text.Trim(), tbDesc.Text.Trim(), dtp.Value);
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    db.Configuration.AutoDetectChangesEnabled = false;
                    ElectricStoreMetro.Category cat = new ElectricStoreMetro.Category();
                    cat.Name = tbName.Text.Trim();
                    cat.Description = tbDesc.Text.Trim();
                    cat.Date = dtp.Value;
                    db.Entry(cat).State = EntityState.Added;

                    db.SaveChanges();
                }
                Notifications.Notfication("New Category Created", "Category " +tbName.Text +" created successfully.", Color.Green);
                InitiateControls();
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Category not saved. see below details for more information\nDetails: "+ex.Message, "Saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count==0)
            {
                MetroMessageBox.Show(this, "Please select category first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            string name = dgv.SelectedRows[0].Cells[1].Value.ToString();
            try
            {
                for (int i = 0; i < dgv.SelectedRows.Count; i++ )
                {
                        int id = Convert.ToInt32(dgv.SelectedRows[i].Cells[0].Value);
                        //CategoryClass.Delete(id);
                        using (ShopDBEntities db = new ShopDBEntities())
                        {
                            var ent = db.Categories.FirstOrDefault(c => c.CatID == id);
                            db.Categories.Remove(ent);
                            db.Entry(ent).State = EntityState.Deleted;
                            db.SaveChanges();
                        }
                }

                Notifications.Notfication("Categories Removed", "Operation Successful", Color.Green);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, "Category not deleted from the system.\nDetails: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            
            InitiateControls();
        }
        int id;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (ShopDBEntities db = new ShopDBEntities())
            {
                var cat = db.Categories.FirstOrDefault(c => c.CatID == id);
                cat.Name = tbName.Text;
                cat.Description = tbDesc.Text;
                cat.Date = dtp.Value;
                db.Entry(cat).State = EntityState.Modified;
                db.SaveChanges();

                Notifications.Notfication("Updated", "Category Updated", Color.Green);
                InitiateControls();
            }
        }
       
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                tbName.Text = row.Cells["Name"].Value.ToString();
                tbDesc.Text = row.Cells["Description"].Value.ToString();
                id=Convert.ToInt32(row.Cells["CatID"].Value.ToString());
            }
        }
    }
}
