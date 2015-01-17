using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _09.TraverseFolder
{
    class TraverseFolder
    {/*Write a program to traverse given directory and write to a XML file its contents together with all subdirectories and files. 
      * Use tags <file> and <dir> with appropriate attributes. 
      * For the generation of the XML document use the class XmlWriter*/
        static void Main(string[] args)
        {
            string fileName = "..\\..\\foldersAndFiles.xml";
            string startFolder = "..\\..\\";
            Encoding encoding = Encoding.GetEncoding("windows-1251");

            using (XmlTextWriter writer = new XmlTextWriter(fileName, encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                TraverseDirectory(writer, startFolder);
                writer.WriteEndDocument();
            }

        }

        private static void TraverseDirectory(XmlTextWriter writer, string startFolder)
        {
            var folders = Directory.GetDirectories(startFolder);
            var files = Directory.GetFiles(startFolder);

            writer.WriteStartElement("folder");
            foreach (var folder in folders)
            {
                writer.WriteElementString("dir", folder);
                TraverseDirectory(writer, folder);
            }
            foreach (var file in files)
            {
                writer.WriteElementString("file", file);
            }
                writer.WriteEndElement();

        }
    }
}
