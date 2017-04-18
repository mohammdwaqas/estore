using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace ElectricStoreMetro.MainForm.Return
{
    class ReturnClass
    {
        public static DataSet SelectCartItems(string orderno)
        {
            DataSet ds = new DataSet();

            using (var con = new SqlConnection(DBConnection.cn))
            {
                string query = @"select
	  [ProductID]
	  ,Items.Name
	  ,OrderItems.[Quantity]
	  ,Measurements.MeasurementID AS 'UnitID'
	   ,OrderItems.[SalePrice] AS 'Price'
	   ,OrderItems.[TotalPrice] AS 'Amount'
	  ,OrderItems.[PurchasePrice]
	  ,OrderItems.[SalePrice]
	  ,Orders.[TotalPayment] AS 'TotalPayment'
	  ,Convert(Date,Orders.[TransactionDate]) AS 'TransactionDate'
	  ,Customers.Name AS 'CustomerName'
    ,Customers.CustID AS 'CustomerID'
	FROM OrderItems
	LEFT JOIN Items ON OrderItems.ProductID=Items.ItemID
	LEFT JOIN Measurements ON OrderItems.SaleUnitID = Measurements.MeasurementID
	LEFT JOIN Orders ON OrderItems.OrderNo=Orders.OrderNo
	LEFT JOIN Customers ON OrderItems.CustomerID = Customers.CustID
	WHERE OrderItems.OrderNo=@OrderNo;";
                using (var cmd = new SqlCommand(query,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@OrderNo", SqlDbType.NVarChar).Value = orderno;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            return ds;
        }
    }
}
