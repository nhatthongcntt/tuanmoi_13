using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ontap_ktralan2_lienketsql
{
    internal class Modify
    {
        public 
            Modify() {

        }
        SqlDataAdapter _dataAdapter;
        SqlCommand _sqlCommand;
        public DataTable Table(string query)//tra ve bang du lieu
        {
            DataTable dttable = new DataTable();
            using (SqlConnection sqlConnection = Connection.GetConnection()) 
            {
                sqlConnection.Open();
                _dataAdapter = new SqlDataAdapter(query,sqlConnection);
                _dataAdapter.Fill(dttable); //do day du lieu vao table
                sqlConnection.Close();
            }
            return dttable;
        }
        public void Command(string query)
        {
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                _sqlCommand = new SqlCommand(query,sqlConnection);
                _sqlCommand.ExecuteNonQuery();
                sqlConnection.Close ();
            }
        }
    }
}
