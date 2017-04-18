using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Sale
{
    public partial class frSelectProducts : MetroFramework.Forms.MetroForm
    {
        DataSet r;
        public frSelectProducts()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet();
        private void frSelectProducts_Load(object sender, EventArgs e)
        {
            //r = ElectricStoreMetro.MainForm.Product.ProductClass.Select();
            //dgv.DataSource = r.Tables[0].DefaultView;
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {

            
                //foreach (DataGridViewRow row in dgv.Rows)
                //{
                //    if (row.Cells[3].Value.ToString().Equals(txtSearchName.Text))
                //    {
                //        row.Selected = true;
                //        break;
                //    }
                //}
                // DataView dv = detailsDS.Tables[0].DefaultView;

            
                 DataView dv = r.Tables[0].DefaultView;

                 dv.RowFilter = "Name LIKE '%" + txtSearchName.Text.Trim() + "%'";

             
            }
        private decimal CalculateAmount(decimal price, decimal qty)
        {
            decimal amount = price * qty;
            return amount;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //frSale obj = new frSale();
            //obj.dgv.DataSource = SelectProductClass.SelectedItem(
            //    (txtID.Text), txtName.Text, Convert.ToInt32(numQty.Value), Convert.ToDecimal(txtPrice.Text), CalculateAmount(Convert.ToDecimal(txtPrice.Text), numQty.Value),
            //    Convert.ToDecimal(txtPurchasePrice.Text), Convert.ToDecimal(txtSalePrice.Text));

            
            
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv.Rows[e.RowIndex];
                //frmQuickMessage frm = new frmQuickMessage();

                //frm.tbName.Text = row.Cells[1].Value.ToString();
                //frm.tbNum.Text = row.Cells[2].Value.ToString();
                //frm.lblSessionID.Text = sessionID;
                txtID.Text = row.Cells["ItemID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtQtyAvl.Text = row.Cells["RemQty"].Value.ToString();
                txtPrice.Text = row.Cells["Saleprice"].Value.ToString();
                txtQtyAvl.Text = row.Cells["RemQty"].Value.ToString();
                txtDiscount.Text = row.Cells["DiscountPercent"].Value.ToString();

                txtPurchasePrice.Text = row.Cells["PurchasePrice"].Value.ToString();
                txtSalePrice.Text = row.Cells["Saleprice"].Value.ToString();
              

               // frm.ShowDialog();
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtDesc_Click(object sender, EventArgs e)
        {

        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            decimal price = Convert.ToDecimal(txtPrice.Text);
            decimal qty =numQty.Value ;
            decimal amount = price * qty;

            numQty.Maximum=(Convert.ToDecimal(txtQtyAvl.Text));
            txtAmount.Text = amount.ToString();


        }

        private void chkDiscount_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDiscount.Checked)
            {
                int discount = Convert.ToInt32(txtDiscount.Text);
               
                decimal amount = Convert.ToDecimal(txtAmount.Text);
                decimal _amount = (amount * discount) / 100;
                txtAmount.Text = _amount.ToString();
            }
           
        }
        }
    }

