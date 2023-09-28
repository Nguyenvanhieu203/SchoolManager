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
    public partial class funstion : Form
    {
        public funstion()
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

       
    }
}
