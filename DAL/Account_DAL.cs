using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Account_DAL : ConnectToSql
    {
        public bool accountCheck(Accounts a)
        {
            string name = a.nameUser;
            string pass = a.password;
            openConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "checkAccount";
            cmd.Parameters.AddWithValue("@username", name);
            cmd.Parameters.AddWithValue("@password", pass);
            cmd.Connection = sqlCon;

            int k = (int)cmd.ExecuteScalar();
            if (k > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
