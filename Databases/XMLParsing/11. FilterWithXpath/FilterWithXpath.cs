using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace _11.FilterWithXpath
{/*Write a program, which extract from the file catalog.xml the prices for all albums, published 5 years ago or earlier. Use XPath query.
*/
    class FilterWithXpath
    {
        static void Main(string[] args)
        {
            XElement doc = XElement.Load("..\\..\\..\\catalog.xml");

            var prices =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("year").Value) > 3
                select album.Element("price").Value;

            foreach (var price in prices)
            {
                Console.WriteLine(price);
            }
        }
    }
}
