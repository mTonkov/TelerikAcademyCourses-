using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicLibrary.Services.Models
{
    public class SongModel
    {
        public static Expression<Func<Song, SongModel>> FromSong
        {
            get
            {
                return s => new SongModel
                {
                    Id = s.Id,
                    Title = s.Title,
                    Genre = s.Genre,
                    Year = s.Year
                };
            }
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Genre { get; set; }
    }
}