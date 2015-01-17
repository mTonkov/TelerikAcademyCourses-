using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _10.TraverseFolderXElement
{/*Rewrite the last exercises using XDocument, XElement and XAttribute.
*/
    class TraverseFolderXElement
    {
        static void Main(string[] args)
        {
            string fileName = "..\\..\\foldersAndFiles.xml";
            string startFolder = "..\\..\\";

            XElement document = new XElement("folders");

            TraverseDirectory(startFolder, document);

            document.Save(fileName);

        }

        private static void TraverseDirectory(string startFolder, XElement document)
        {
            var folders = Directory.GetDirectories(startFolder);
            var files = Directory.GetFiles(startFolder);
            var currentFolder = new XElement("folder-content");

            foreach (var folderName in folders)
            {
                XElement folder = new XElement("dir");
                folder.Value = folderName;
                currentFolder.Add(folder);
                TraverseDirectory(folderName, currentFolder);
            }

            foreach (var fileName in files)
            {
                XElement file = new XElement("file");
                file.Value = fileName;
                currentFolder.Add(file);
            }
            document.Add(currentFolder);

        }
    }
}
