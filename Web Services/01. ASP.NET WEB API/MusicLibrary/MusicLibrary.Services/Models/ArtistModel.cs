using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace MusicLibrary.Services.Models
{
    public class ArtistModel
    {
        public static Expression<Func<Artist, ArtistModel>> FromArtist
        {
            get
            {
                return a => new ArtistModel
                {
                    Id = a.Id,
                    Name = a.Name,
                    Country = a.Country,
                    DateOfBirth = a.DateOfBirth
                };
            }
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}