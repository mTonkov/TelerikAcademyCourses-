using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Models
{
    public class Artist
    {
        public Artist()
        {
            this.Songs = new HashSet<Song>();
            this.Albums = new HashSet<Album>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public virtual ICollection<Song> Songs { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
