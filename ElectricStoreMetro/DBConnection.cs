using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ElectricStoreMetro
{
    public class DBConnection
    {
        public static string cn = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
    }
}
