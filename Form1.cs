using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HitClick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(+1);
            if (progressBar1.Value == 99)
            {
                MessageBox.Show("Ваш результат: " + i);
                timer1.Enabled = false;
                progressBar1.Value = 0;
                button2.Visible = false;
                i = 0;
                label7.Text = "0";
                label8.Text = "...";
                button5.Visible = false;
                button4.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label8.Text = "Вы запустили таймер";
            button2.Visible = true;
        }

        int i = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            ++i;
            label7.Text = "" + i;
            button4.Visible = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                timer1.Enabled = false;
                progressBar1.Value = 0;
                button2.Visible = false;
                i = 0;
                label7.Text = "0";
                label8.Text = "...";
                button5.Visible = false;
                button4.Visible = true;
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Вы не запустили таймер!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                timer1.Enabled = false;
                button5.Visible = true;
                button4.Visible = false;
                button2.Visible = false;
                button1.Visible = false;
            }
            else
            {
                MessageBox.Show("Вы не запустили таймер!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                timer1.Enabled = true;
                button5.Visible = false;
                button4.Visible = true;
                button2.Visible = true;
                button1.Visible = true;
            }
            else
            {
                MessageBox.Show("Вы не запустили таймер!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frm = new Form2();
            frm.Show();
        }
    }
}
