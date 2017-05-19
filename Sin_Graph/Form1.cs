using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sin_Graph
{
    public partial class Form1 : Form
    {
        int WIDTH = 300;
        int HEIGHT = 300;
        int secLength = 140;
        int minLength = 110;
        int hourLength = 80;

        Bitmap bmp;
        Graphics g;

        int cx;
        int cy;


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);
            cx = WIDTH / 2;
            cy = HEIGHT / 2;
            this.BackColor = Color.White;


            g = Graphics.FromImage(bmp);
            g.DrawEllipse(new Pen(Color.Red, 2),0,0, WIDTH, HEIGHT);
            pictureBox1.Image = bmp;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.DrawEllipse(new Pen(Color.Red, 2), 0, 0, WIDTH, HEIGHT);
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            int[] coords = new int[2];            

            coords = msCoord(ss, secLength);
            g.DrawLine(new Pen(Color.Black, 2), cx, cy, coords[0], coords[1]);

            coords = msCoord(mm, minLength);
            g.DrawLine(new Pen(Color.DarkBlue, 3), cx, cy, coords[0], coords[1]);

            coords = mhCoord(hh%12, mm, hourLength);
            g.DrawLine(new Pen(Color.DarkBlue, 4), cx, cy, coords[0], coords[1]);

            Refresh();
            pictureBox1.Image = bmp;
            g.Dispose();
            
        }

        public int[] msCoord(int val, int length)
        {
            int[] coord = new int[2];

            val *= 6;

            coord[0] = cx + (int)(length * Math.Sin(Math.PI * val / 180));
            coord[1] = cy - (int)(length * Math.Cos(Math.PI * val / 180));

            return coord;
        }

        public int[] mhCoord(int hour,int min, int length)
        {
            int[] coord = new int[2];

            int val = ((hour * 30) + (int)(min * 0.5));

            coord[0] = cx + (int)(length * Math.Sin(Math.PI * val / 180));
            coord[1] = cy - (int)(length * Math.Cos(Math.PI * val / 180));

            return coord;
        }
    }
}
