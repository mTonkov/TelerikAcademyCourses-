namespace MusicLibrary.Data
{
    using MusicLibrary.Models;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public interface IMusicLibraryDbContext
    {
        IDbSet<Artist> Artists { get; set; }

        IDbSet<Album> Albums { get; set; }

        IDbSet<Song> Songs { get; set; }


        IDbSet<T> Set<T>() where T : class;

        DbEntityEntry<T> Entry<T>(T entity) where T : class;

        void SaveChanges();
    }
}
