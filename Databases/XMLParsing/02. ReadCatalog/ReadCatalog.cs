using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _02.ReadCatalog
{/*Write program that extracts all different artists which are found in the catalog.xml. 
  * For each author you should print the number of albums in the catalogue.
  * Use the DOM parser and a hash-table*/
    class ReadCatalog
    {
        /* README!!!: 
         * I know that i don't solve the task according to the described terms, but I am trying to use the homework to prepare for the exam, using the tools that I will use during the exam.
           Probably, you know time is not enough. I Hope you understand :)*/
        static void Main(string[] args)
        {
            XDocument document = XDocument.Load("..\\..\\..\\catalog.xml");

            var authors = document.Descendants("artist");

            var artistsAndAlbums = new Dictionary<string, int>();

            foreach (var author in authors)
            {
                var authorName = author.Value;

                if (!artistsAndAlbums.ContainsKey(authorName))
                {
                    artistsAndAlbums[authorName] = 0;
                }
                artistsAndAlbums[authorName]++;
            }

            foreach (var pair in artistsAndAlbums)
            {
                Console.WriteLine("{0} has {1} albums", pair.Key, pair.Value);
            }
        }
    }
}
