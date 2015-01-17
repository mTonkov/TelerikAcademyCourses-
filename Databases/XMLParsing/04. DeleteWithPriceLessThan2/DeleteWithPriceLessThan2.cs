using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _04.DeleteWithPriceLessThan2
{/*Using the DOM parser write a program to delete from catalog.xml all albums having price > 2*/
    class DeleteWithPriceLessThan2
    {
        static void Main(string[] args)
        {
            XDocument doc = XDocument.Load("..\\..\\..\\catalog.xml");

            var albumsToDelete =
                from album in doc.Descendants("album")
                where int.Parse(album.Element("price").Value) > 2
                select album;

                albumsToDelete.ToList().ForEach(album => album.Remove());

            doc.Save("..\\..\\..\\newCatalog.xml");
        }
    }
}
