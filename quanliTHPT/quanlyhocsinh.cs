using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace quanliTHPT
{
    public partial class student : Form
    {
      
        public student()
        {
            InitializeComponent();
        }
        BLL_hocsinh hocsinh = new BLL_hocsinh();
        private void student_Load(object sender, EventArgs e)
        {
            dgv.DataSource = hocsinh.GetAllstudens();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
