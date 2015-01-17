using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

using MusicLibrary.Services.Models;

namespace MusicLibrary.ConsoleClient
{
    class ConsoleClient
    {
        private static readonly HttpClient Client = new HttpClient { BaseAddress = new Uri("http://localhost:5937/api/") };

        static void Main(string[] args)
        {
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //AddNewSong("Latest Hit", "Super Cool", 2014);

            var response = Client.GetAsync("Song/AllSongs").Result;
            if (response.IsSuccessStatusCode)
            {
                var songsResult = response.Content.ReadAsStringAsync().Result;
                var songs = JsonConvert.DeserializeObject<IEnumerable<SongModel>>(songsResult);

                Console.WriteLine("{0,5} {1,8} {2,15}", "Id", "Title", "Genre");
                Console.WriteLine();
                foreach (var song in songs)
                {
                    Console.WriteLine("{0,5}. {1,-10} ----- {2,5}", song.Id, song.Title, song.Genre);
                }
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }

        public static void AddNewSong(string title, string genre, int year)
        {
            var song = new SongModel
            {
                Title = title,
                Genre = genre,
                Year = year
            };

            HttpContent songContent = new StringContent(JsonConvert.SerializeObject(song));
            songContent.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/json");

            var response = Client.PostAsync("Song/AddSong", songContent).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Song added!");
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}

