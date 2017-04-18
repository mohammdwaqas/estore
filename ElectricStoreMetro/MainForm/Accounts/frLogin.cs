using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using LibCore;

namespace ElectricStoreMetro.MainForm.Accounts
{
// ReSharper disable once InconsistentNaming
    public partial class frLogin : Form
    {
        public frLogin()
        {
            InitializeComponent();
        }
        LibCore.DataSecurity security = new DataSecurity();
        

        private void frLogin_Load(object sender, EventArgs e)
        {

            try
            {
                pictureBox1.Image = Properties.Resources.login;
                SqlHelper s = new SqlHelper();
                
                if (s.isConnected())
                {
                    DataSet ds = AccountClass.Select();
                    cboUser.DataSource = ds.Tables[0];
                    cboUser.DisplayMember = "Name";
                    cboUser.ValueMember = "UserID";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"this is error" + ex.Message);

            }

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cboUser.SelectedValue.ToString() + " " + txtPass.Text);
            using (ShopDBEntities db = new ShopDBEntities())
            {
                int userid = Convert.ToInt32(cboUser.SelectedValue);
                var user = db.Users.SingleOrDefault(u => u.UserID == userid);

                string pass = security.Decrypt(user.Password, true);
                //MessageBox.Show("Password: " + pass);
                if (pass == txtPass.Text)
                {
                    //CONFIRM OK
                    Notifications.Notfication("Authorization OK!", "Welcome " + cboUser.Text, System.Drawing.Color.Green);
                    this.Hide();
                    frMain f = new frMain();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Password error. please try again with valid password.", "Error Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                    txtPass.Clear();
                    txtPass.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
