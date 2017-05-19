using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Preperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            stopTimer1.Enabled = true;
            stopTimer2.Enabled = true;
            stopTimer3.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(8);
            l1.Text = num.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(8);
            l2.Text = num.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(8);
            l3.Text = num.ToString();
        }

        private void stopTimer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            stopTimer1.Enabled = false;
        }

        private void stopTimer2_Tick(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            stopTimer2.Enabled = false;
        }

        private void stopTimer3_Tick(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            stopTimer3.Enabled = false;
        }
    }
}
