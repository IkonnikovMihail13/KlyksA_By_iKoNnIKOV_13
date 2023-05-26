using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Klyaksa_Shop
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 newFrom = new Form13();
            newFrom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form13 newFrom = new Form13();
            newFrom.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 newFrom = new Form1();
            newFrom.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form6 newFrom = new Form6();
            newFrom.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form7 newFrom = new Form7();
            newFrom.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form8 newFrom = new Form8();
            newFrom.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            Form9 newFrom = new Form9();
            newFrom.Show();
        }
    }
}
