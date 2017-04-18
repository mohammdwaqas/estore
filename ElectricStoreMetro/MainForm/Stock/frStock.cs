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
using System.Data.SqlClient;
using System.Configuration;


namespace ElectricStoreMetro.MainForm.Stock
{
    public partial class frStock : Form
    {
        public frStock()
        {
            InitializeComponent();
        }
        DataSet detailDs = new DataSet();
        #region private variables
        int _paramQty;
        int _paramQtyGreaterThan;
        #endregion
        #region query
        string queryGreaterThan = @"SELECT [ItemID]
                   ,[Categories].[Name] AS Category
                   ,[Items].[Name]
                   ,[Qty]
                    ,[PurchasePrice]
                    ,[Saleprice]
                   ,[DiscountPercent]
                   ,[Items].[Description]
                   ,[DateCreated]
                   ,[DateUpdated]
                   ,[UsedQty]
                   ,[RemQty]
                    FROM [dbo].[Items]
                    LEFT JOIN Categories ON Items.CatID = Categories.CatID
                    LEFT JOIN Users ON Items.UserID = Users.UserID
                    WHERE Items.RemQty > @qty";

        string queryLessThan = @"SELECT [ItemID]
                   ,[Categories].[Name] AS Category
                   ,[Items].[Name]
                   ,[Qty]
                    ,[PurchasePrice]
                    ,[Saleprice]
                   ,[DiscountPercent]
                   ,[Items].[Description]
                   ,[DateCreated]
                   ,[DateUpdated]
                   ,[UsedQty]
                   ,[RemQty]
                    FROM [dbo].[Items]
                    LEFT JOIN Categories ON Items.CatID = Categories.CatID
                    LEFT JOIN Users ON Items.UserID = Users.UserID
                    WHERE Items.RemQty < @qty";
        #endregion
        //string ConStr = ConfigurationManager.ConnectionStrings[""]
        private void frStock_Load(object sender, EventArgs e)
        {
            initiate();
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv.Rows[e.RowIndex];
                txtID.Text = row.Cells["ItemID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtCat.Text = row.Cells["Category"].Value.ToString();
                numStock.Value = Convert.ToDecimal(row.Cells["Qty"].Value);
                numRem.Value = Convert.ToDecimal(row.Cells["RemQty"].Value);
            }
        }
        private bool validateInput(decimal stockQty, decimal newQty)
        {
            bool isValidate = false;

            if (stockQty < newQty)
            {
                isValidate = true;
            }
            else if (stockQty <= newQty)
            {
                isValidate = false;
            }

            return isValidate;
        }
        private void initiate()
        {
            int q = -1;
            detailDs = ElectricStoreMetro.MainForm.Product.ProductClass.Select(q);
            dgv.DataSource = detailDs.Tables[0].DefaultView;

            txtName.Clear();
            txtCat.Clear();
            txtID.Clear();
            numAddStock.Value = 0;
            numRem.Value = 0;
            numStock.Value = 0;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (validateInput(numStock.Value, numAddStock.Value))
            //{
            try
            {
                using (ShopDBEntities db = new ShopDBEntities())
                {
                    int id = Convert.ToInt32(txtID.Text);
                    var item = db.Items.SingleOrDefault(c => c.ItemID == id);
                    item.Qty = item.Qty + Convert.ToInt32(numAddStock.Value);

                    db.Entry(item).State = EntityState.Modified;
                    db.SaveChanges();
                    Notifications.Notfication("Item Updated Successfully!", txtName.Text + " quantity updated successfully", Color.Green);
                    initiate();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\n:" + ex.Message);
            }
            //}
            //else
            //{
            //    MessageBox.Show("Error");
            //}
        }

        private void numAddStock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailDs.Tables[0].DefaultView;
            dv.RowFilter = "Name LIKE '%" + txtSearchName.Text.Trim() + "%'";
        }

        private void txtSearchCat_TextChanged(object sender, EventArgs e)
        {
            DataView dv = detailDs.Tables[0].DefaultView;
            dv.RowFilter = "Category LIKE '%" + txtSearchCat.Text.Trim() + "%'";
        }

        private void txtSearchName_Click(object sender, EventArgs e)
        {

        }

        private void btnQueryUnder_Click(object sender, EventArgs e)
        {
            if (txtQueryUnder.Text == string.Empty)
            {
                MessageBox.Show("Required value missing. please try again.", "Value missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                _paramQty = Convert.ToInt32(txtQueryUnder.Text.Trim());
                #region GET DATA
                try
                {
                    Fetch(_paramQty, queryLessThan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                #endregion

            }
        }

        private void Fetch(int _paramQty, string query)
        {
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = _paramQty;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    detailDs.Clear();
                    da.Fill(detailDs);
                }
            }
            dgv.DataSource = detailDs.Tables[0].DefaultView;
        }

        private void txtQueryUnder_KeyPress(object sender, KeyPressEventArgs e)
        {
            //this will allow only digits 
            if (!char.IsDigit(e.KeyChar) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnQueryHigh_Click(object sender, EventArgs e)
        {
            if (txtQueryHigh.Text == string.Empty)
            {
                MessageBox.Show("Required value missing. please try again.", "Value missing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                
                try
                {
                    _paramQtyGreaterThan = Convert.ToInt32(txtQueryHigh.Text.Trim());
                    Fetch(_paramQtyGreaterThan, queryGreaterThan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            initiate();
        }
    }
}
