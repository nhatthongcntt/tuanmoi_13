using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ontap_ktralan2_lienketsql
{
    internal class Connection
    {
        private static string stringConnection = @"Data Source=DESKTOP-1LTU3CE;Initial Catalog=QL_NHANVIEN;Integrated Security=True";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
