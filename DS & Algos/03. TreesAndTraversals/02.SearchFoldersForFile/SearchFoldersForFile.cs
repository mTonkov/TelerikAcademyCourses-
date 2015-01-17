using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.SearchFoldersForFile
{/*Write a program to traverse the directory C:\WINDOWS and all its subdirectories recursively and to display all files matching the mask *.exe. Use the class System.IO.Directory.
*/
    public class SearchFoldersForFile
    {
        static void Main(string[] args)
        {// When searching in C:\WINDOWS, there is a System.UnauthorizedAccessException, so I changed the search
            string rootFolderName = "D:\\Movies";
            string[] files = Directory.GetFiles(rootFolderName, "*.avi", SearchOption.AllDirectories);

            for (int i = 0; i < files.Length; i++)
            {
                string[] file = files[i].Split('\\');
                Console.WriteLine(file[file.Length - 1]);
            }
        }       
    }
}
