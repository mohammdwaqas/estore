using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ElectricStoreMetro.MainForm.Accounts
{
    public class AccountClass
    {
        public static string cn = DBConnection.cn;
        public static void Create(string name, string pass, string address, string cell)
        {
             
             using (var con = new SqlConnection(cn))
            {
                using (var cmd = new SqlCommand(Queries.AccountClassCreate, con))
                {
                    //open connection
                    con.Open();

                    //provide parameters
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@pass", System.Data.SqlDbType.NVarChar).Value = pass;
                    cmd.Parameters.Add("@cell", System.Data.SqlDbType.NVarChar).Value = cell;
                    cmd.Parameters.Add("@address", System.Data.SqlDbType.NVarChar).Value = address;

                    //execute query
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static DataSet Select()
        {
            DataSet ds = new DataSet();
            using (var con = new SqlConnection(cn))
            {
                using (var cmd = new SqlCommand(Queries.AccountClassSelect, con))
                {
                    //open connection 
                    con.Open();

                    //execute query
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds);
                }
            }
            return ds;
        }
        public static void Edit(int id, string name, string pass, string cell, string address)
        {
            using (var con = new SqlConnection(cn))
            {
                using (var cmd = new SqlCommand(Queries.AccountClassEdit, con))
                {
                    //connection open
                    con.Open();

                    //parameters
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
                    cmd.Parameters.Add("@cell", SqlDbType.NVarChar).Value = cell;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;

                    //EXECUTE
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Delete(int id)
        {
            using (var con = new SqlConnection(cn))
            {
                using (var cmd = new SqlCommand(Queries.AccountClassDelete, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
