namespace MusicLibrary.Services.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    using MusicLibrary.Data;
    using MusicLibrary.Data.Contracts;
    using MusicLibrary.Models;
    using MusicLibrary.Services.Models;

    public class ArtistController : ApiController
    {
        private IMusicLibraryData dataProvider;

        public ArtistController()
            : this(new MusicLibraryData())
        {
        }

        public ArtistController(IMusicLibraryData data)
        {
            this.dataProvider = data;
        }

        [HttpGet]
        public IHttpActionResult AllArtists()
        {
            var allArtists = this.dataProvider
                .Artists
                .All()
                .Select(ArtistModel.FromArtist);

            return Ok(allArtists);
        }

        [HttpPost]
        public IHttpActionResult AddArtist(ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newArtist = new Artist
            {
                Name = artist.Name,
                Country = artist.Country,
                DateOfBirth = artist.DateOfBirth
            };

            this.dataProvider.Artists.Add(newArtist);
            this.dataProvider.SaveChanges();
            return Ok(newArtist);
        }

        [HttpPut]
        public IHttpActionResult ChangeArtist(int id, ArtistModel artist)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var artistToChange = this.dataProvider
                            .Artists
                            .All()
                            .FirstOrDefault(a => a.Id == id);

            if (artistToChange == null)
            {
                return BadRequest("The artist you are trying to moify does NOT exist");
            }

            artistToChange.Name = artist.Name;
            artistToChange.DateOfBirth = artist.DateOfBirth;
            artistToChange.Country = artist.Country;

            this.dataProvider.SaveChanges();
            artist.Id = artistToChange.Id;

            return Ok(artist);
        }

        [HttpDelete]
        public IHttpActionResult RemoveArtist(int id)
        {
            var artistToDelete = this.dataProvider
                .Artists
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (artistToDelete == null)
            {
                return BadRequest("The artist you are trying to remove does NOT exist");
            }

            this.dataProvider.Artists.Delete(artistToDelete);
            this.dataProvider.SaveChanges();

            return Ok();
        }
    }
}
