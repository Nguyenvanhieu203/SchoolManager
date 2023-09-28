using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal interface IPerson
    {
        string hoTen { get; set; }
        string gioiTinh { get; set; }
        DateTime ngaysinh { get; set; }
        string diachi { get; set; }
        string email { get; set; }
    }
}
