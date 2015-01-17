using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public abstract class FileSystemNode
    {
        public FileSystemNode(string filename, FileSystemNode parent, string path)
        {
            this.FileName = filename;
            this.Parent = parent;
            this.Path = path;
            this.Children = new List<FileSystemNode>();
        }

            public IList<FileSystemNode> Children { get; private set; }
            public FileSystemNode Parent { get; private set; }
            public string FileName { get; private set; }
            public string Path { get; private set; }
    }
}
