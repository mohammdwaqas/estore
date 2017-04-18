using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ElectricStoreMetro.MainForm.Product
{
    public class ProductClass
    {
        public static DataSet Select(int minStockQty)
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ProductClassSelect, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = minStockQty;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }

            }
            return ds;
        }

        public static DataSet SelectReport(DateTime from, DateTime to)
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ProductClassSelectReport, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@from", SqlDbType.DateTime).Value = from;
                    cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }

            }
            return ds;
        }

        public static DataSet SelectReportSales(DateTime from, DateTime to)
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ViewSalesForReport, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@from", SqlDbType.DateTime).Value = from;
                    cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }

            }
            return ds;
        }

        public static DataSet SelectReportSales2(int WalkingCustomerID, int CompleteOStatusID, int PendingOStatusID, DateTime from, DateTime to)
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ViewSalesReport, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@CompleteOStatusID", SqlDbType.Int).Value = CompleteOStatusID;
                    cmd.Parameters.Add("@PendingOStatusID", SqlDbType.Int).Value = PendingOStatusID;
                    cmd.Parameters.Add("@WalkingCustID", SqlDbType.Int).Value = WalkingCustomerID;
                    cmd.Parameters.Add("@from", SqlDbType.DateTime).Value = from;
                    cmd.Parameters.Add("@to", SqlDbType.DateTime).Value = to;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }

            }
            return ds;
        }
        public static DataSet PopulateDropDown()
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ProductClassPopulateDropDown, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            return ds;
        }

        public static DataSet PopulateMeasurementDropDown()
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ProductClassPopulateMeasurement, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            return ds;
        }
        public static DataSet SelectProducts()
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.SelectProducts, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            return ds;
        }
        public static void Create(string name, int catid, int userid, string desc, int qty, int usedqty, DateTime dtCreate, DateTime dtUpdate)
        {
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.ProductClassCreate,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@catID", SqlDbType.Int).Value = catid;
                    cmd.Parameters.Add("@userID", SqlDbType.Int).Value = userid;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@qty", SqlDbType.Int).Value = qty;
                    cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc;
                    cmd.Parameters.Add("@dtCreated", SqlDbType.DateTime).Value = dtCreate;
                    cmd.Parameters.Add("@dtUpdated", SqlDbType.DateTime).Value = dtUpdate;
                    cmd.Parameters.Add("@usedQty", SqlDbType.Int).Value = usedqty;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
