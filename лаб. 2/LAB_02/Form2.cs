using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void year_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Year.ToString();
        }

        private void hours_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Hour.ToString();
        }

        private void min_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.Minute.ToString();
        }
    }
}
