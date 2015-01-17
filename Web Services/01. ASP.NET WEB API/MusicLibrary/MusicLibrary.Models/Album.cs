using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicLibrary.Models
{
    public class Album
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

        public virtual ICollection<Artist> Artist { get; set; }

    }
}
