using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace quanliTHPT
{
    public partial class login : Form
    {
         taikhoan Taikhoan = new taikhoan();
        taikhoanbll tkbll = new taikhoanbll();
        public login()
        {
            InitializeComponent();
            tb_user.ForeColor = Color.LightGray;
            tb_user.Text = "Tên đăng nhập";
            this.tb_user.Leave += new System.EventHandler(this.textBox1_Leave);
            this.tb_user.Enter += new System.EventHandler(this.textBox1_Enter);

            tb_pass.ForeColor = Color.LightGray;
            tb_pass.Text = "Mật khẩu";
            this.tb_pass.Leave += new System.EventHandler(this.textBox2_Leave);
            this.tb_pass.Enter += new System.EventHandler(this.textBox2_Enter);
        }

         private void textBox1_Leave(object sender, EventArgs e)
        {
            if (tb_user.Text == "")
            {
                tb_user.Text = "Tên đăng nhập";
                tb_user.ForeColor = Color.Gray;
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tb_user.Text == "Tên đăng nhập")
            {
                tb_user.Text = "";
                tb_user.ForeColor = Color.Black;
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (tb_pass.Text == "Mật khẩu")
            {
                tb_pass.Text = "";
                tb_pass.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
           if (tb_pass.Text == "")
           {
                tb_pass.Text = "Mật khẩu";
               tb_pass.ForeColor = Color.Gray;
            }
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(32, 145, 194);
            

        }
        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Transparent;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor= Color.FromArgb(32, 145, 194);
            lb_loginwtFB.Visible = true;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Transparent;
            lb_loginwtFB.Visible = false;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(32,145,194);
            lb_loginwtgg.Visible = true;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Transparent;
            lb_loginwtgg.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Taikhoan.sTaiKhoan = tb_user.Text;
            Taikhoan.sMatKhau = tb_pass.Text;
            string getuser = tkbll.checklogin(Taikhoan);
            switch (getuser)
            {
                case "requit_user":
                    MessageBox.Show("tai khoan khong duoc de chong");
                    return;
                case "requit_pass":
                    MessageBox.Show("mat khau khong duoc de trong");
                    return;
                case "tai khoan mat khau khong chinh xac":
                    MessageBox.Show("tài khoản hoặc mặt khẩu không chính xác");
                    return;
            }
            ManagerMain fs = new ManagerMain();
            this.Hide();
            fs.ShowDialog();
            this.Show();

        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(34,1,132);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.FromArgb(34, 1, 132);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Dangky dk = new Dangky();
            this.Hide();
            dk.ShowDialog();
            this.Show();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
   
}
    
