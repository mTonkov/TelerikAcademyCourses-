using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystem
{
    public class Folder : FileSystemNode
    {
        public Folder(string name, FileSystemNode parent, string path)
            : base(name, parent, path)
        {
            this.Files = new List<File>();
            this.SubFolders = new List<Folder>();
        }

        public List<File> Files { get; private set; }

        public List<Folder> SubFolders { get; private set; }
    }
}
