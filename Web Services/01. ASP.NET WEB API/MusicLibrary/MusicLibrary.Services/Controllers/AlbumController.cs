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
    
    public class AlbumController : ApiController
    {
        private IMusicLibraryData dataProvider;

        public AlbumController()
            : this(new MusicLibraryData())
        {

        }
        public AlbumController(IMusicLibraryData data)
        {
            this.dataProvider = data;
        }

        [HttpGet]
        public IHttpActionResult AllAlbums()
        {
            var allAlbums = this.dataProvider
                .Albums
                .All()
                .Select(AlbumModel.FromAlbum);

            return Ok(allAlbums);
        }

        [HttpPost]
        public IHttpActionResult AddAlbum(AlbumModel album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newAlbum = new Album
            {
                Title = album.Title,
                Producer = album.Producer,
                Year = album.Year
            };

            this.dataProvider.Albums.Add(newAlbum);
            this.dataProvider.SaveChanges();
            return Ok(newAlbum);
        }

        [HttpPost]
        public IHttpActionResult AddSongToAlbum(int id, SongModel song)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var album = this.dataProvider
                .Albums
                .SearchFor(a => a.Id == id)
                .FirstOrDefault();

            if (album==null)
            {
                return BadRequest("No such album");
            }

            var newSong = new Song
            {
                Title = song.Title,
                Genre = song.Genre,
                Year = song.Year
            };

            album.Songs.Add(newSong);
            this.dataProvider.SaveChanges();

            song.Id = newSong.Id;
            return Ok(song);
        }

        [HttpPut]
        public IHttpActionResult ChangeAlbum(int id, AlbumModel album)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var albumToChange = this.dataProvider
                            .Albums
                            .All()
                            .FirstOrDefault(a => a.Id == id);

            if (albumToChange == null)
            {
                return BadRequest("The album you are trying to moify does NOT exist");
            }

            albumToChange.Title = album.Title;
            albumToChange.Producer = album.Producer;
            albumToChange.Year = album.Year;

            this.dataProvider.SaveChanges();
            album.Id = albumToChange.Id;

            return Ok(album);
        }

        [HttpDelete]
        public IHttpActionResult RemoveAlbum(int id)
        {
            var albumToDelete = this.dataProvider
                .Albums
                .All()
                .FirstOrDefault(a => a.Id == id);

            if (albumToDelete == null)
            {
                return BadRequest("The album you are trying to remove does NOT exist");
            }

            this.dataProvider.Albums.Delete(albumToDelete);
            this.dataProvider.SaveChanges();

            return Ok();
        }
    }
}
