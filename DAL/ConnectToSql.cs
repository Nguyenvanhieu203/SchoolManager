using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConnectToSql
    {
        string strCon = @"Data Source=.;Initial Catalog=SchoolManager;Integrated Security=True";
        public SqlConnection sqlCon = null;

        public void openConnection()
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();

            }

        }
        public void closeConnection()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }
}
