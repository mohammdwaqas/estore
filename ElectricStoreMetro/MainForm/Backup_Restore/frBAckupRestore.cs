using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Backup_Restore
{
    public partial class frBAckupRestore : Form
    {
        //string activeDB;
        private SqlConnection sqlconnect;
        private SqlCommand sqlcmd;
        private SqlDataReader dr;
        string sql = "";
        string c = "";
        public frBAckupRestore()
        {
            InitializeComponent();
        }

        private void frBAckupRestore_Load(object sender, EventArgs e)
        {
            //pictureBox1.Enabled = false;
            tbDSource.Text = SystemInformation.ComputerName;
            //try
            //{
            //string c = "Data Source = " + tbDSource.Text + ";integrated Security=true;";
            // c = "Data Source = .\SQLEXPRESS\Dell-Laptop;integrated Security=true;";
            c = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            sqlconnect = new SqlConnection(c);
            sqlconnect.Open();
            sql = " SELECT * from sys.databases d where d.database_id>4 ";
            sqlcmd = new SqlCommand(sql, sqlconnect);
            dr = sqlcmd.ExecuteReader();
            cboxDBSelection.Items.Clear();
            while (dr.Read())
            {
                cboxDBSelection.Items.Add(dr[0].ToString());
            }

            //if (Class1.isLoggedIn == false)
            //{
            //    cboxDBSelection.Items.Add("ElectricStore");
            //}
            cboxDBSelection.SelectedItem = "ShopDB";
            tbDBPath.Enabled = true;
            tbDSource.Enabled = true;
            tbRestorePath.Enabled = true;

            cboxDBSelection.Enabled = true;
            btnBackup.Enabled = true;
            btnBrowse.Enabled = true;
            btnRestoreBrowse.Enabled = true;
            btnRestoreRestore.Enabled = true;

            //}
            ////catch (Exception ex)
            ////{
            ////    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////}
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbDBPath.Text = dlg.SelectedPath;
            }
        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Database Files(*.bak)|*.bak";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbRestorePath.Text = ofd.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                //pictureBox1.Visible = true;
                // MessageBox.Show(cboxDBSelection.SelectedItem.ToString())
                sqlconnect = new SqlConnection(c);
                sqlconnect.Open();
                sql = "BACKUP DATABASE " + cboxDBSelection.Text + " TO DISK ='" + tbDBPath.Text + "\\" + cboxDBSelection.Text.Trim() + "(Date " + DateTime.Now.ToString("dd-MM-yy") + ").bak'";
                sqlcmd = new SqlCommand(sql, sqlconnect);
                sqlcmd.ExecuteNonQuery();
                MessageBox.Show("Backup Created Successfully", @"Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbDBPath.Clear();
                // pictureBox1.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRestoreRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboxDBSelection.Text.Trim() == "")
                {
                    MessageBox.Show("Please Select database to be restored", @"Select Database", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    //    if(Class1.isLoggedIn==false)
                    //{
                    //    sqlconnect = new SqlConnection(c);
                    //    sqlconnect.Open();
                    //    sql = "Restore Database " + cboxDBSelection.Text + " FROM Disk='" + tbRestorePath.Text + "'WITH REPLACE;";
                    //    sqlcmd = new SqlCommand(sql, sqlconnect);
                    //    sqlcmd.ExecuteNonQuery();
                    //    MessageBox.Show("Database Restoration Completed Successfully! Plesae start Application Again", "Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    Application.Exit();
                    //}
                    // pictureBox1.Visible = true;
                    sqlconnect = new SqlConnection(c);
                    sqlconnect.Open();
                    sql = "use master";
                    sql += " ALTER DATABASE " + cboxDBSelection.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE;";
                    sql += "Restore Database " + cboxDBSelection.Text + " FROM Disk='" + tbRestorePath.Text + "'WITH REPLACE;";
                    sql += @"ALTER DATABASE FcProject
                            SET MULTI_USER;";
                    sqlcmd = new SqlCommand(sql, sqlconnect);
                    sqlcmd.ExecuteNonQuery();
                    MessageBox.Show("Database Restoration Completed Successfully!", @"Restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    // pictureBox1.Visible = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
