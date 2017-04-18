using ElectricStoreMetro.MainForm.Product;
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
	public partial class frParamMonthly : MetroFramework.Forms.MetroForm
	{
		public frParamMonthly()
		{
			InitializeComponent();
		}

		private void frParamMonthly_Load(object sender, EventArgs e)
		{

		}

		private void metroTile2_Click(object sender, EventArgs e)
		{
			viewRptProfitLoss oInstance = new viewRptProfitLoss();
			int CompleteOStatusID = Convert.ToInt32(Properties.Settings.Default["CompleteOStatusID"]);
			int PendingOStatusID = Convert.ToInt32(Properties.Settings.Default["PendingOStatusID"]);
            int walkingCustID = Convert.ToInt32(Properties.Settings.Default["WalkingCustomerID"]);
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date;

			#region BUSINESS INFO
			using (ShopDBEntities db = new ShopDBEntities())
			{

				var setup = db.CompanySetups.SingleOrDefault();


				oInstance.txtBusinessName.Text = setup.Name;
				oInstance.txtAddress.Text = setup.Address;
				// txtAbout.Text = setup.About;
				oInstance.txtCell.Text = setup.Contact;
				oInstance.txtReportFooter.Text = setup.ReportFooter;
				oInstance.txtReportHeader.Text = setup.ReportHeader;
				oInstance.txtSlogan.Text = setup.Slogan;



			}
			#endregion
			#region ProfitLossInfo

			//SESSION
			oInstance.txtSession.Text= from.ToShortDateString() +" to "+to.ToShortDateString();


            DataSet SalesReportDS = ProductClass.SelectReportSales2(walkingCustID, CompleteOStatusID, PendingOStatusID, from, to);

			oInstance.txtNamedCustomer.Text = SalesReportDS.Tables[0].Rows[0]["namedcustomers"].ToString();
            oInstance.txtWalkingCustomer.Text = SalesReportDS.Tables[0].Rows[0]["WalkingCustomers"].ToString();

			oInstance.txtTotalSP.Text = SalesReportDS.Tables[0].Rows[0]["TotalSalePrice"].ToString();
			
            oInstance.txtTotalPP.Text = SalesReportDS.Tables[0].Rows[0]["TotalPurchasePrice"].ToString();
           
            oInstance.txtItemSoldDistinct.Text = SalesReportDS.Tables[0].Rows[0]["TotalSoldItemsDistinct"].ToString();
            oInstance.txtSoldItemsInDistinct.Text = SalesReportDS.Tables[0].Rows[0]["TotalSoldItemsInDistinct"].ToString();
            oInstance.txtNoSales.Text = SalesReportDS.Tables[0].Rows[0]["TotalOrders"].ToString();
            oInstance.txtPendingSales.Text = SalesReportDS.Tables[0].Rows[0]["PendingOrders"].ToString();
            oInstance.txtCompletedSales.Text = SalesReportDS.Tables[0].Rows[0]["CompleteOrders"].ToString();
           
            oInstance.txtDiscountGiven.Text = SalesReportDS.Tables[0].Rows[0]["TotalDiscount"].ToString();

			//SALES INFO
			
			#endregion

            #region CALCULATE CASH IN HAND

            #endregion
            oInstance.ShowDialog();
		}
		private void getBusinessInfo()
		{
		   
		}
		private void getProfitLossInfo()
		{
			//SESSION
			
		}

		private void metroTile3_Click(object sender, EventArgs e)
		{
			using (ShopDBEntities _context = new ShopDBEntities())
			{
                DateTime from = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;

				_context.Configuration.ProxyCreationEnabled = false;
				SelectedData f = new SelectedData();
				f.dgv.DataSource = ElectricStoreMetro.MainForm.Product.ProductClass.SelectReport(from, to).Tables[0].DefaultView;
                f.gboxStock.Visible = true;
                f.btnPrintStock.Visible = true;
                f.ShowDialog();
			} 
		   
			
		}

		private void metroTile1_Click(object sender, EventArgs e)
		{
			using (ShopDBEntities _context = new ShopDBEntities())
			{
                DateTime from = dtpFrom.Value.Date;
                DateTime to = dtpTo.Value.Date;

				_context.Configuration.ProxyCreationEnabled = false;
				SelectedData f = new SelectedData();
				f.dgv.DataSource = ElectricStoreMetro.MainForm.Product.ProductClass.SelectReportSales(from, to).Tables[0].DefaultView;
				f.gboxSale.Visible = true;
                f.btnPrintSales.Visible = true;
				f.ShowDialog();

			} 
		   
		}
	}
}
