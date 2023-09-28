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
    public partial class ManagerMain : Form
    {
        public ManagerMain()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Techer qllgv = new Techer();
            this.Hide();
            qllgv.ShowDialog();
            this.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {    
            student hs = new student();
            this.Hide();
            hs.ShowDialog();
            this.Show();


        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void funstion_Load(object sender, EventArgs e)
        {

        }
    }
}
