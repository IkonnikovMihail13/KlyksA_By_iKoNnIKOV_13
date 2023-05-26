using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Klyaksa_Shop
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form9 newFrom = new Form9();
            newFrom.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form10 newFrom = new Form10();
            newFrom.Show();
        }
    }
}
