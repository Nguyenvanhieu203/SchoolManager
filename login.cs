using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliTHPT
{
    public partial class login : Form
    {
        public class Controller
        {
            public string User { get; set; }
            public string Pass { get; set; }
        }
        public login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "" && txtpass.Text == "")
                MessageBox.Show("ten dang nhap và mat khau không được trống");
            else if (txtuser.Text == "")
                MessageBox.Show("ten dang nhap không được trống");
            else if (txtpass.Text == "")
                MessageBox.Show("mat khau không được trống");
            else
                if (txtuser.Text == "admin" && txtpass.Text == "12345")
            {
                Controller obj = new Controller();
                obj.User = "admin";
                obj.Pass = "12345";
               funstion cn = new funstion();
                this.Hide();
                cn.ShowDialog();
                this.Show();
        
                
            }
            else
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai, xin vui lòng đăng nhập lại");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
