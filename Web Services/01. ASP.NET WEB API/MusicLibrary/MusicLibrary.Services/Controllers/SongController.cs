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
    
    public class SongController : ApiController
    {
        private IMusicLibraryData dataProvider;

        public SongController()
            : this(new MusicLibraryData())
        {

        }
        public SongController(IMusicLibraryData data)
        {
            this.dataProvider = data;
        }

        [HttpGet]
        public IHttpActionResult AllSongs()
        {
            var allSongs = this.dataProvider
                .Songs
                .All()
                .Select(SongModel.FromSong);

            return Ok(allSongs);
        }

        [HttpPost]
        public IHttpActionResult AddSong(SongModel song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newSong = new Song
            {
                Title = song.Title,
                Genre = song.Genre,
                Year = song.Year
            };

            this.dataProvider.Songs.Add(newSong);
            this.dataProvider.SaveChanges();

            return Ok(newSong);
        }

        [HttpPut]
        public IHttpActionResult ChangeSong(int id, SongModel song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var songToChange = this.dataProvider
                            .Songs
                            .All()
                            .FirstOrDefault(s => s.Id == id);

            if (songToChange == null)
            {
                return BadRequest("The Song you are trying to moify does NOT exist");
            }

            songToChange.Title = song.Title;
            songToChange.Genre = song.Genre;
            songToChange.Year = song.Year;

            this.dataProvider.SaveChanges();
            song.Id = songToChange.Id;

            return Ok(song);
        }

        [HttpDelete]
        public IHttpActionResult RemoveSong(int id)
        {
            var songToDelete = this.dataProvider
                .Songs
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (songToDelete == null)
            {
                return BadRequest("The Song you are trying to remove does NOT exist");
            }

            this.dataProvider.Songs.Delete(songToDelete);
            this.dataProvider.SaveChanges();

            return Ok();
        }

    }
}
