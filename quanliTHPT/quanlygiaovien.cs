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
    public partial class Techer : Form
    {
 
        public Techer()
        {
            InitializeComponent();
            
        }
         private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        BLL_giaovien giaovien = new BLL_giaovien();
        private void Techer_Load(object sender, EventArgs e)
        {
            dgv.DataSource = giaovien.GetAllTeacher();
            //LoadTeachers();
        }

      
  /*private void button1_Click(object sender, EventArgs e)
        {
            // Mở form để nhập thông tin giáo viên mới
            Techer addTeacherForm = new Techer();
            if (addTeacherForm.ShowDialog() == DialogResult.OK)
            {
                // Thêm giáo viên mới vào CSDL
                Giaovien teacher = addTeacherForm;
                giaovien.AddTeacher(teacher);

                // Hiển thị thông báo thành công và cập nhật lại DataGridView
                MessageBox.Show("Teacher added successfully.");
                LoadTeachers();
            }
        }
        private void LoadTeachers()
        {
            // Lấy danh sách giáo viên từ CSDL và hiển thị lên DataGridView
            List<Giaovien> teachers = giaovien.GetAllTeacher();
            dgv.DataSource = teachers;
        }*/
    }
}
