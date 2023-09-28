using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Giaovien:IPerson
    {
        public string maGV { get; set; }
        public string  hoTen { get; set; }
      public  string gioiTinh { get; set; }
      public  DateTime ngaysinh { get; set; }
      public  string diachi { get; set; }
      public  string email { get; set; }
        public string dienthoai { get; set; }
        public string monday { get; set; }
       

    }
}
