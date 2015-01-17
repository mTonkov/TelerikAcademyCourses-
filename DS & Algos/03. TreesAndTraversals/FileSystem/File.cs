using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class File : FileSystemNode
    {
        public File(long size, string filename, FileSystemNode parent, string path)
            : base(filename, parent, path)
        {
            this.Size = size;
        }

        public long Size { get; private set; }
    }
}
