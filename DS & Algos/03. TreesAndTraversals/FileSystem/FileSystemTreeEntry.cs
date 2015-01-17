using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileSystem
{/*
  Define classes File { string name, int size } and Folder { string name, File[] files, Folder[] childFolders } and 
  using them build a tree keeping all files and folders on the hard drive starting from C:\WINDOWS. 
  Implement a method that calculates the sum of the file sizes in given subtree of the tree and test it accordingly. 
  Use recursive DFS traversal.
*/
    public class FileSystemTree
    {
        static void Main(string[] args)
        {
            var tree = new Dictionary<string, Folder>();
            var root = new Folder("Movies", null, "D:\\Movies");
            BuildTree(tree, root);

            long sum = 0;
            CalculateFolderSize(tree, "300 Rise of an Empire [2014] Subbed HDRip XViD juggs[ETRG]", ref sum);
            Console.WriteLine("Size of files in bytes: {0} ", sum);

        }

        private static void BuildTree(IDictionary<string, Folder> tree, Folder root)
        {
            var fileNamesInFolder = Directory.GetFiles(root.Path);
            for (int i = 0; i < fileNamesInFolder.Length; i++)
            {
                string currentFilePath = fileNamesInFolder[i];
                FileInfo theFile = new FileInfo(currentFilePath);
                var currentFileInFolder = new File(theFile.Length, currentFilePath, root, currentFilePath);
                root.Files.Add(currentFileInFolder);
            }

            var folderNamesInFolder = Directory.GetDirectories(root.Path);
            for (int i = 0; i < folderNamesInFolder.Length; i++)
            {
                string currentFolderPath = folderNamesInFolder[i];
                string[] pathParts = currentFolderPath.Split('\\');
                string currentFolderName = pathParts[pathParts.Length - 1];
                var currentSubFolder = new Folder(currentFolderName, root, currentFolderPath);
                root.SubFolders.Add(currentSubFolder);
                tree[currentFolderName] = currentSubFolder;
            }

            foreach (var folder in root.SubFolders)
            {
                BuildTree(tree, folder);
            }
        }

        private static long CalculateFolderSize(IDictionary<string, Folder> tree, string folderName, ref long sum)
        {
            Folder currentFolder = tree[folderName];
            foreach (var file in currentFolder.Files)
            {
                sum += file.Size;
            }

            foreach (var folder in currentFolder.SubFolders)
            {
                CalculateFolderSize(tree, folder.FileName, ref sum);
            }

            return sum;
        }
    }
}
