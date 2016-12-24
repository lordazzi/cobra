using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cobra
{
    public partial class Form1 : Form
    {
        public int x = 0, y = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = ("Se ferro ¬¬");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                timer1.Enabled = true;
                progressBar1.Visible = true;
            }
            else
            {
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (x != 100)
            {
                progressBar1.Value = x;
                x++;
            }
            else
            {
                Form EBA = new Form2();
                
                EBA.Show();
                x = 0;
                timer1.Enabled = false;
                progressBar1.Visible = false;
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            y = 10;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            y = 20;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            y = 30;
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            y = 40;
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            y = 50;
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                timer1.Enabled = true;
                progressBar1.Visible = true;
            }
            else
            {
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}