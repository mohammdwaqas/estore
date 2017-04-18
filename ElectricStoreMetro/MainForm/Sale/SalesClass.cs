using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStoreMetro.MainForm.Sale
{

    public class SalesClass
    {
        public string OrderNo()
        {
            bool isAlreadyExist = true;
            
            string orderNo;
            orderNo = GenerateOrderNo();
            isAlreadyExist = CheckOrderExistance(orderNo);
            //lblOrderNo.Text = orderNo;


            return orderNo;
        }

        private bool CheckOrderExistance(string orderNo)
        {
            bool orderNoExist = false;

            using (var con = new SqlConnection(DBConnection.cn))
            {

                string query = "SELECT * FROM ORDERS WHERE OrderNo=@orderNo";
                using (var cmd = new SqlCommand(query, con))
                {
                    var dtAnyData = new DataTable();
                    con.Open();
                    cmd.Parameters.AddWithValue("@orderNo", orderNo);
                    SqlDataReader reader = cmd.ExecuteReader();
                    dtAnyData.Load(reader);
                    if (dtAnyData.Rows.Count > 0)
                    {
                        orderNoExist = true;
                    }
                }


            }

            return orderNoExist;
        }

       private string GenerateOrderNo()
        {
            string orderNo = "";
            var rnd = new Random();
            long orderPart1 = rnd.Next(100000, 9999999);
            long orderPart2 = rnd.Next(1000, 9999);
            orderNo = "DS-" + orderPart1 + "-" + orderPart2;
            return orderNo;
        }
    }





}