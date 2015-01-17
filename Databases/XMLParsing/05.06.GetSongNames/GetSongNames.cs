using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _05.GetSongNames
{/*Write a program, which using XmlReader extracts all song titles from catalog.xml.
Rewrite the same using XDocument and LINQ query*/
    class GetSongNames
    {
        static void Main(string[] args)
        {

            using (XmlReader reader = XmlReader.Create("..\\..\\..\\catalog.xml"))
            {

                int indent = 0;
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine(new string(' ', indent % 10) + reader.ReadElementString());
                        indent++;
                        if (indent % 10 == 0)
                        {
                            Console.WriteLine();
                        }
                    }

                }
            }
        }
    }
}
