using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectricStoreMetro.MainForm.Reports
{
    public partial class SelectedData : MetroFramework.Forms.MetroForm
    {
        public SelectedData()
        {
            InitializeComponent();
        }

        private void SelectedData_Load(object sender, EventArgs e)
        {
            try
            {
                if (dgv.Columns[0].HeaderText == "OrderNo")
                {
                    MessageBox.Show("Sale Report");

                    try
                    {
                        decimal TotalAmount = 0;
                        decimal PaymentDue = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            TotalAmount += Convert.ToDecimal(dgv.Rows[i].Cells["TotalAmount"].Value);
                            PaymentDue += Convert.ToDecimal(dgv.Rows[i].Cells["PaymentDue"].Value);
                        }
                        txtTotalAmount.Text = TotalAmount.ToString("N2");
                        txtPaymentDue.Text = PaymentDue.ToString("N2");
                    }
                    catch 
                    {
                      
                    }

                }
                if (dgv.Columns[0].HeaderText == "Category")
                {
                    MessageBox.Show("Stock Report");
                    try
                    {
                        decimal PurchasePrice = 0;
                       // decimal Saleprice = 0;
                        for (int i = 0; i < dgv.Rows.Count; i++)
                        {
                            PurchasePrice += Convert.ToDecimal(dgv.Rows[i].Cells["PurchasePrice"].Value);
                            //PaymentDue += Convert.ToDecimal(dgv.Rows[i].Cells["PaymentDue"].Value);
                        }
                        txtStockAmount.Text = PurchasePrice.ToString("N2");
                       // txtPaymentDue.Text = PaymentDue.ToString("N2");
                    }
                    catch
                    {

                    }
                }
            }
            catch 
            {

               
            }
           
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal StockPrice = 0;
                int StockItems = dgv.Rows.Count;

# region CALCULATE SUM FOR STOCK
                //try
                //{
                //    for (int i = 0; i < dgv.Rows.Count; i++)
                //    {
                //        decimal purchasePrice = 0;
                //        purchasePrice = Convert.ToDecimal(dgv.Rows[i].Cells["PurchasePrice"].Value);
                //        int Qty = Convert.ToInt32(dgv.Rows[i].Cells["RemQty"].Value);
                //        StockPrice += Qty * purchasePrice;
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error while calculating SUM\nDetails: " + ex.Message);
                //}
#endregion
                DGVPrinter printer = new DGVPrinter();
                printer.Title = "Shop Management System";
                printer.SubTitle = "Sum of Stock Amount(s): " + txtStockAmount.Text + "\nNo of Products: " + StockItems.ToString();


                printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
                printer.PageNumbers = true;
                printer.PageNumberInHeader = false;
                printer.PorportionalColumns = true;
                printer.HeaderCellAlignment = StringAlignment.Near;

                printer.Footer = "Project by Developer Studio";

                printer.FooterSpacing = 12;
                printer.PrintDataGridView(dgv);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error\nDetails: " + ex.Message, "Error");
            }
        }

        private void btnPrintSales_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Shop Management System";
            printer.SubTitle = "Sum of Sales Amount(s): " + txtTotalAmount.Text + "\nNo of Sales: " + dgv.Rows.Count.ToString() + "\nPayment Due: "+txtPaymentDue.Text;


            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;

            printer.Footer = "Project by Developer Studio";

            printer.FooterSpacing = 12;
            printer.PrintDataGridView(dgv);
        }
    }
}
