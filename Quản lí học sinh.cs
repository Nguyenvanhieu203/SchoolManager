﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanliTHPT
{
    public partial class student : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLth2;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void laoddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from HocSinh";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;

        }
        public student()
        {
            InitializeComponent();
        }

        private void student_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            laoddata();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
