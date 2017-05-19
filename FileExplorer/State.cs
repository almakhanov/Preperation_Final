using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileExplorer
{
    public class State
    {
        int index;
        DirectoryInfo dir;

        public int maxIndex;

        public DirectoryInfo Dir
        {
            get
            {
                return dir;
            }
            set
            {
                dir = value;
                maxIndex = dir.GetFileSystemInfos().Length;
            }
        }

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                if (value >= 0 && value < maxIndex)
                {
                    index = value;
                }
            }//set
        }
    }
}
