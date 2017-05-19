using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;

            if (hh < 10)
            {
                hhLbl.Text = "0" + hh.ToString();
            }
            else hhLbl.Text = hh.ToString();

            if (mm < 10)
            {
                mmLbl.Text = "0" + mm.ToString();
            }
            else mmLbl.Text = mm.ToString();

            if (ss < 10)
            {
                ssLbl.Text = "0" + ss.ToString();
            }
            else ssLbl.Text = ss.ToString();
        }
    }
}
