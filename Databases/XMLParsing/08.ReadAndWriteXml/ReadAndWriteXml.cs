using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _08.ReadAndWriteXml
{/*Write a program, which (using XmlReader and XmlWriter) reads the file catalog.xml and creates the file album.xml, in which stores in appropriate way the names of all albums and their authors*/
    class ReadAndWriteXml
    {
        static void Main(string[] args)
        {
            XElement doc = new XElement("albums");
            XElement album = new XElement("album");
            using (XmlReader reader = XmlReader.Create("..\\..\\..\\catalog.xml"))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "album-name"))
                    {
                        album = new XElement("album");
                        var name = new XElement("name");
                        name.Value = reader.ReadElementContentAsString();
                        album.Add(name);
                    }
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "artist"))
                    {
                        var author = new XElement("author");
                        author.Value = reader.ReadElementContentAsString();
                        album.Add(author);
                        doc.Add(album);
                    }
                }
            }
            doc.Save("..\\..\\album.xml");
        }
    }
}
