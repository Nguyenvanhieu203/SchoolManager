using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_giaovien
    {
        DAl_giaovien dataAccessLayer;

        public BLL_giaovien()
        {
            dataAccessLayer = new DAl_giaovien();teacherDAL = new TeacherDAL();
        }

        public DataTable GetAllTeacher()
        {
            string query = "SELECT * FROM GIAOVIEN";
            return dataAccessLayer.ExecuteQuery(query);
        }
        private TeacherDAL teacherDAL;


        public bool AddTeacher(Giaovien teacher)
        {
            return teacherDAL.AddTeacher(teacher);
        }
    }
    
}
