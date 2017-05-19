using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        State state = new State
        {
            Dir = new DirectoryInfo(@"D:\"),
            Index = 0
        };


        public Form1()
        {
            InitializeComponent();
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            FileSystemInfo[] infos = state.Dir.GetFileSystemInfos();
            for (int i = 0; i < state.maxIndex; i++)
            {
                listView1.Items.Add((i + 1) + (") ")+ infos[i].Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
