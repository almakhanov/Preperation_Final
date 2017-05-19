using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphs
{
    public partial class Form1 : Form
    {
        float x;
        float y;
        int height;
        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
            x = 0;
            y = 0;
            height = 150;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            g = Graphics.FromImage(bmp);
            
            pictureBox1.Image = bmp;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            y =height*(float)Math.Sin(Math.PI*x/180)+height+10;
            x = x + 1;
            if (x % 90 == 0)
                x++;
            g.FillEllipse(new Pen(Color.Black).Brush, x, y, 5, 5);
            label1.Text = string.Format("x={0}, y={1}",x,y);
            Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }
    }
    
}
