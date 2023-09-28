using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BLL_hocsinh
    {
        DAL_hocsinh dataAccessLayer;

        public BLL_hocsinh()
        {
            dataAccessLayer = new DAL_hocsinh();
        }

        public DataTable GetAllstudens()
        {
            string query = "SELECT * FROM HOCSINH";
            return dataAccessLayer.ExecuteQuery(query);
        }
    }
}
