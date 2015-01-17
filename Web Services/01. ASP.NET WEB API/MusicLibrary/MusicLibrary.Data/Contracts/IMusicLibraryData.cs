using MusicLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary.Data.Contracts
{
   public interface IMusicLibraryData
    {
        IRepository<Artist> Artists { get; }

        IRepository<Album> Albums  { get; }

        IRepository<Song> Songs   { get; }

        void SaveChanges();
    }
}
