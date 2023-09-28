using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DAl_giaovien
    {
        public DataTable ExecuteQuery(string query)
        { SqlConnection connection = DataAccess.OpenConnection();
            DataTable dataTable = new DataTable();
       
               
               SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
            DataAccess.CloseConnection(connection);
            return dataTable;
        }
   }
    public class TeacherDAL
    {
  

        
            SqlConnection connection = DataAccess.OpenConnection();
        

        public bool AddTeacher(Giaovien teacher)
        {
            bool result = false;
            try
            {
                SqlCommand command = new SqlCommand("ThemGiaoVien", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@tenGiaoVien", teacher.hoTen);
                command.Parameters.AddWithValue("@chuyenMon", teacher.monday);
                command.Parameters.AddWithValue("@dienThoai", teacher.dienthoai);
                command.Parameters.AddWithValue("@maGiaoVien", teacher.maGV);
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
            }
            finally
            {
                DataAccess.CloseConnection(connection);
            }
            return result;
        }
    }
}
