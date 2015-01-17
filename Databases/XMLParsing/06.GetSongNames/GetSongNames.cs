using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _06.GetSongNames
{/*Write a program, which using XmlReader extracts all song titles from catalog.xml.
Rewrite the same using XDocument and LINQ query*/
    class GetSongNames
    {
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("..\\..\\..\\catalog.xml");

            var songs = document.Descendants("song");

            int indent = 0;
            foreach (var song in songs)
            {
                Console.WriteLine(new string(' ', indent % 10) + song.Element("title").Value);
                indent++;

                if (indent % 10 == 0)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
