using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicLibrary.Models
{
    public class Song
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }

        public Artist Artist { get; set; }

        public Album Album { get; set; }
    }
}
