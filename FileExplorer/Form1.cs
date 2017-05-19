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

        Stack<string> st = new Stack<string>();

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
                listView1.Items.Add(infos[i].FullName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)(Keys.Back))
            {
                st.Pop();
                int count = 0;   
                
                if (st.Count == 0)
                {
                    st.Push(@"D:\");
                }
                for (int i = 0; i < count; i++)
                {
                    listView1.Items[0].Remove();
                }
                listView1.Clear();
                DirectoryInfo direct = new DirectoryInfo(@"" + st.Peek());
                FileSystemInfo[] x = direct.GetFileSystemInfos();
                
                for (int i = 0; i < x.Length; i++)
                {
                    listView1.Items.Add(x[i].FullName);
                }
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                int count = 0;     
                for(int i = 0; i < listView1.Items.Count; i++)
                {
                    if (listView1.Items[i].Selected == true)
                    {
                        count = i;
                    }
                }

                string path = listView1.Items[count].Text;
                st.Push(path);
                for (int i = 0; i < count; i++)
                {
                    listView1.Items[0].Remove();
                }
                listView1.Clear();
                DirectoryInfo direct = new DirectoryInfo(@"" + path);
                FileSystemInfo[] x = direct.GetFileSystemInfos();

                for (int i = 0; i < x.Length; i++)
                {
                    listView1.Items.Add(x[i].FullName);
                }
            }
        }
    }
}
