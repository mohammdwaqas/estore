using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace ElectricStoreMetro.MainForm.Category
{
    public class CategoryClass
    {
        public static void Create(string name, string desc, DateTime dt)
        {
            using (var con = new SqlConnection(DBConnection.cn))
            {
                
                using (var cmd = new SqlCommand(Queries.CategoryClassCreate,con))
                {
                    con.Open();
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@desc", System.Data.SqlDbType.NVarChar).Value = desc;
                    cmd.Parameters.Add("@date", System.Data.SqlDbType.NVarChar).Value = dt;

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static DataSet Select()
        {
            
            using (var con = new SqlConnection(DBConnection.cn))
            {

                using (var cmd = new SqlCommand(Queries.CategoryClassSelect, con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    return ds;
                }
            }
        }

        public static void Delete(int id)
        {
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.CategoryClassDelete, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Edit(int id, string name, string desc, DateTime dt)
        {
            using (var con = new SqlConnection(DBConnection.cn))
            {
                using (var cmd = new SqlCommand(Queries.CategoryClassEdit, con))
                {
                    con.Open();
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@desc", System.Data.SqlDbType.NVarChar).Value = desc;
                    cmd.Parameters.Add("@date", System.Data.SqlDbType.NVarChar).Value = dt;
                    cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
