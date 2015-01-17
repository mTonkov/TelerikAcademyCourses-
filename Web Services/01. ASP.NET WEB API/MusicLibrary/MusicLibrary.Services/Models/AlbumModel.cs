using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicLibrary.Services.Models
{
    public class AlbumModel
    {
        public static Expression<Func<Album, AlbumModel>> FromAlbum
        {
            get
            {
                return a => new AlbumModel
                {
                    Id = a.Id,
                    Title = a.Title,
                    Producer = a.Producer,
                    Year = a.Year
                };
            }
        }
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }

        public string Producer { get; set; }
    }
}