using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricStoreMetro.MainForm.Accounts
{
    public class SqlHelper
    {
       public bool isConnected()
        {
            
            var con = new SqlConnection(DBConnection.cn);
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            return true;
        }
    }
}
