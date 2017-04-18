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
using LibCore;
using Tulpep.NotificationWindow;
using System.Data.Entity;


namespace ElectricStoreMetro.MainForm.Accounts
{
    public partial class frAccount : MetroFramework.Forms.MetroForm
    {
        public frAccount()
        {
            InitializeComponent();
        }
        LibCore.DataSecurity security = new DataSecurity();
        private void frAccount_Load(object sender, EventArgs e)
        {
            //initiate form
            initiate();
        }

        private void initiate()
        {
            dgv.DataSource = AccountClass.Select().Tables[0].DefaultView;
            tbCreateAdd.Clear();
            tbCreateCell.Clear();
            tbCreateName.Clear();
            tbCreatePass.Clear();
            tbCreateName.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCreateName.Text.Trim())
                || string.IsNullOrWhiteSpace(tbCreatePass.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Validation Error. Please check for emty fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(tbCreateName.Text.Trim())
                || !string.IsNullOrWhiteSpace(tbCreatePass.Text.Trim()))
            {
                try
                {
                    #region Apply Encryption
                    string password = security.Encrypt(tbCreatePass.Text.Trim(), true);
                    #endregion

                    #region Create Account

                    //execute main funtion
                    //AccountClass.Create(tbCreateName.Text.Trim(), password, tbCreateAdd.Text.Trim(), tbCreateCell.Text.Trim());
                    using (ShopDBEntities db = new ShopDBEntities())
                    {
                        ElectricStoreMetro.User user = new User();
                        user.Name = tbCreateName.Text;
                        user.Password = password;
                        user.Cell = tbCreateCell.Text;
                        user.Address = tbCreateAdd.Text;

                        db.Entry(user).State = EntityState.Added;
                        db.SaveChanges();
                        
                    }
                    #endregion
                    //MetroMessageBox.Show(this, "Operation Completed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Notifications.Notfication("Account Created", "Account " + tbCreateName.Text + " created successfully.", Color.SeaGreen);
                    initiate();
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error found\nDetails: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        int id=0;
        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>-1)
            {

                try
                {
                    DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                    string pass = security.Decrypt(row.Cells[2].Value.ToString(), true);
                    id = Convert.ToInt32(row.Cells[0].Value);
                    tbCreateName.Text = row.Cells[1].Value.ToString();
                    tbCreateCell.Text = row.Cells[3].Value.ToString();
                    tbCreateAdd.Text = row.Cells[4].Value.ToString();
                    tbCreatePass.Text = pass;
                }
                catch (Exception ex)
                {

                    MetroMessageBox.Show(this, "Error \nDetails: " + ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCreateName.Text) || string.IsNullOrEmpty(tbCreatePass.Text))
            {
                MetroMessageBox.Show(this, "Validation Error. Please check for emty fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!string.IsNullOrEmpty(tbCreateName.Text) || !string.IsNullOrEmpty(tbCreatePass.Text))
            {
                try
                {
                    string pass = security.Encrypt(tbCreatePass.Text.Trim(), true);
                    //execute main process(update)
                    AccountClass.Edit(id, tbCreateName.Text, pass, tbCreateCell.Text, tbCreateAdd.Text);
                    id = 0;
                    initiate();
                    MetroMessageBox.Show(this, "Operation Completed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, "Error found\nDetails: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            
            if (id==0)
            {
                MetroMessageBox.Show(this, "Validation Error. Please check for emty fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    var user = db.Users.SingleOrDefault(c => c.UserID == id);
                    db.Users.Remove(user);
                    db.Entry(user).State = EntityState.Deleted;
                    db.SaveChanges();

                }
                id = 0;
                Notifications.Notfication("Account Deleted", "Account " + tbCreateName.Text + " deleted from the system.", Color.Red);
                initiate();
               
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MetroMessageBox.Show(this, "Please remove data from child tables first. " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            

        }
    }
}
