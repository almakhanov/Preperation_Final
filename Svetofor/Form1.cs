using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Svetofor
{
    public partial class Form1 : Form
    {

        Bitmap bmp;
        Graphics g;
        List<Ellipse> ellipses = new List<Ellipse>();
        bool direct = true;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;

            ellipses.Add(new Ellipse(0, 0, pictureBox1.Width, Color.Green));
            ellipses.Add(new Ellipse(0, pictureBox1.Height / 2 - pictureBox1.Width / 2, 
                pictureBox1.Width, Color.Yellow));
            ellipses.Add(new Ellipse(0, pictureBox1.Height - pictureBox1.Width, pictureBox1.Width, Color.Red));
        }

        int count = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < ellipses.Count; i++)
            {
                ellipses[i].Drow(g);
                Refresh();
            }
            if (count == 3)
            {
                count = 0;
            }

            
                ellipses[count].Draw(g);
                Refresh();
            count++;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < ellipses.Count; i++)
            {
                ellipses[i].Drow(g);
                Refresh();
            }
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < ellipses.Count; i++)
            {
                ellipses[i].Drow(g);
                Refresh();
            }
            if (count > 2 )
            {
                direct = false;
                count--;
            }
            if (count < 0)
            {
                direct = true;
                count++;
            }

            if (direct)
            {
                
                ellipses[count].Draw(g);
                Refresh();
                count++;
            }
            else
            {
               
                ellipses[count].Draw(g);
                Refresh();
                count--;
            }
        }
        int green;
        int yellow;
        int red;

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer3.Interval = green * 1000;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer3.Enabled = true;
            green = int.Parse(textBox1.Text);
            yellow = int.Parse(textBox2.Text);
            red = int.Parse(textBox3.Text);
            label1.Text = textBox1.Text;
            label2.Text = textBox2.Text;
            label3.Text = textBox3.Text;
        }
        int c = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            for (int i = 0; i < ellipses.Count; i++)
            {
                ellipses[i].Drow(g);
                Refresh();
            }

            c++;
        }
    }
}
