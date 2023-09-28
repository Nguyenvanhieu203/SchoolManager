using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_hocsinh
    {
        public DataTable ExecuteQuery(string query)
        {
            SqlConnection connection = DataAccess.OpenConnection();
            DataTable dataTable = new DataTable();


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            DataAccess.CloseConnection(connection);
            return dataTable;
        }
    }
}
