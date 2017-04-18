using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ElectricStoreMetro.MainForm.Sale
{
	public class SelectProductClass
	{
		public static DataTable _logDataTable = new DataTable();
		public static DataTable _ReturnProductDT = new DataTable();

		public static DataRow _itemRow;
		public static DataRow _ReturnItemRow;
		public static DataTable SelectedItem(string itemid, string itemname, int qty, decimal price, decimal amount, decimal purprice, decimal saleprice, int unitid)
		{
			_itemRow = _logDataTable.NewRow();
			_itemRow["ProductID"] = itemid;
			_itemRow["Name"] = itemname;
			_itemRow["Quantity"] = qty;
            _itemRow["UnitID"] = unitid;
			_itemRow["Price"] = price;
			_itemRow["Amount"] = amount;
			_itemRow["PurchasePrice"] = purprice;
			_itemRow["SalePrice"] = saleprice;


			_logDataTable.Rows.Add(_itemRow);
			return _logDataTable;
		}
		public static DataTable InitializeDGV()
		{
			_logDataTable.Columns.Clear();
			_logDataTable.Rows.Clear();
			_itemRow = _logDataTable.NewRow();


			_logDataTable.Columns.Add("ProductID");
			_logDataTable.Columns.Add("Name");
			_logDataTable.Columns.Add("Quantity");
			_logDataTable.Columns.Add("UnitID");
			_logDataTable.Columns.Add("Price");
			_logDataTable.Columns.Add("Amount");
			_logDataTable.Columns.Add("PurchasePrice");
			_logDataTable.Columns.Add("SalePrice");

			return _logDataTable;

			//DataRow _logRow;
		}

		public static DataTable InitializeReturnDGV()
		{
			_ReturnProductDT.Columns.Clear();
			_ReturnProductDT.Rows.Clear();
			_ReturnItemRow = _ReturnProductDT.NewRow();


			_ReturnProductDT.Columns.Add("ProductID");
			_ReturnProductDT.Columns.Add("Name");
			_ReturnProductDT.Columns.Add("Quantity");
			_ReturnProductDT.Columns.Add("Price");
			_ReturnProductDT.Columns.Add("Amount");
			_ReturnProductDT.Columns.Add("PurchasePrice");
			_ReturnProductDT.Columns.Add("SalePrice");

			return _ReturnProductDT;

			//DataRow _logRow;
		}
		public static DataSet Select()
		{
			DataSet ds = new DataSet();
			using (var con =new SqlConnection(DBConnection.cn))
			{
				using (var cmd = new SqlCommand("SELECT * FROM CompanySetup", con))
				{
					con.Open();
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(ds);
				}
			}
			return ds;
		}

		public static DataSet SelectProductsByOrderNo(string orderno)
		{
			DataSet ds = new DataSet();
			using (var con = new SqlConnection(DBConnection.cn))
			{
				using (var cmd = new SqlCommand("SELECT * FROM OrderItems where OrderNo=@orderno", con))
				{
					con.Open();
					cmd.Parameters.Add("orderno", SqlDbType.NVarChar).Value = orderno;
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(ds);
				}
			}
			return ds;
		}
		public static DataSet SelectItemsForReturn(string orderno)
		{
			var ds = new System.Data.DataSet();
			using (var con = new SqlConnection(DBConnection.cn))
			{
                string query = @"select 
[OrderItemsID]
	  ,[ProductID]
	  ,Items.Name
	  ,OrderItems.[Quantity]
	   ,OrderItems.[SalePrice] AS 'Price'
	   ,OrderItems.[TotalPrice] AS 'Amount'
	  ,OrderItems.[PurchasePrice]
	  ,OrderItems.[SalePrice]
     ,OrderItems.[SaleUnitID]
	 ,Measurements.Name AS 'Unit'
	  
	 
	FROM OrderItems
	LEFT JOIN Items ON OrderItems.ProductID=Items.ItemID
	LEFT JOIN Measurements ON OrderItems.SaleUnitID = Measurements.MeasurementID
	WHERE OrderNo=@orderno";
				using (var cmd = new SqlCommand(query,con))
				{
					con.Open();
					cmd.Parameters.Add("orderno", SqlDbType.NVarChar).Value = orderno;
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(ds);
				}
			}
			return ds;
		}
		public static DataSet SelectOrderForReturn(string orderno)
		{
			DataSet ds = new System.Data.DataSet();
			using (var con = new SqlConnection(DBConnection.cn))
			{
				con.Open();
				string query = @"SELECT
	   [TransactionDate]
	  ,[ClientID]
	  ,[TotalAmount]
	  ,[SalesTax]
	  ,[Discount]
	  ,[TotalPayment]
	  ,[PaymentDue]
	  ,[TotalToPay]
	 FROM [dbo].[Orders]
	WHERE OrderNo=@orderno";
				using (var cmd = new SqlCommand(query,con))
				{
					cmd.Parameters.Add("@orderno", SqlDbType.NVarChar).Value = orderno;
					SqlDataAdapter da = new SqlDataAdapter(cmd);
					da.Fill(ds);
				}
			}
			return ds;
		}
	}
}
