using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XMLParsing
{/*Create a XML file representing catalogue. The catalogue should contain albums of different artists. 
  * For each album you should define: name, artist, year, producer, price and a list of songs. 
  * Each song should be described by title and duration*/
    public class MusicCatalog
    {
        public static void Main(string[] args)
        {
            XElement file = new XElement("albums");

            for (int i = 0; i < 5; i++)
            {
                string value = (i + 1).ToString();
                XElement album = new XElement("album");

                var albumName = new XElement("album-name");
                albumName.Value = value + " album-name";
                album.Add(albumName);

                var artist = new XElement("artist");
                artist.Value = value + " artist";
                album.Add(artist);

                var year = new XElement("year");
                year.Value = value;
                album.Add(year);

                var producer = new XElement("producer");
                producer.Value = value + " producer"; 
                album.Add(producer);

                var price = new XElement("price");
                price.Value = value;
                album.Add(price);

                var songs = new XElement("songs");
                for (int j = 0; j < 10; j++)
                {
                    var song = new XElement("song");
                    var title = new XElement("title");
                    title.Value = "title " + j + " from the " + albumName.Value;
                    var duration = new XElement("duration");
                    duration.Value = "duration " + j;

                    song.Add(title);
                    song.Add(duration);

                    songs.Add(song);
                }
                album.Add(songs);
                file.Add(album);
            }

            file.Save("..\\..\\..\\catalog.xml");
        }
    }
}
