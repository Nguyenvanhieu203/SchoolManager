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
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
            textBox1.ForeColor = Color.LightGray;
            textBox1.Text = "Tên đăng nhập";
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);

            textBox2.ForeColor = Color.LightGray;
            textBox2.Text = "Mật khẩu";
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);

            textBox3.ForeColor = Color.LightGray;
            textBox3.Text = "Nhập lại mật khẩu";
            this.textBox3.Leave += new System.EventHandler(this.textBox3_Leave);
            this.textBox3.Enter += new System.EventHandler(this.textBox3_Enter);

            textBox4.ForeColor = Color.LightGray;
            textBox4.Text = "Số điện thoại";
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Tên đăng nhập";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Tên đăng nhập")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

       private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Mật khẩu";
                textBox2.ForeColor = Color.Gray;
            }
        }
       
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Mật khẩu")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Nhập lại mật khẩu";
                textBox3.ForeColor = Color.Gray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Nhập lại mật khẩu")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
       }
     
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Số điện thoại";
                textBox4.ForeColor = Color.Gray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Số điện thoại")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
