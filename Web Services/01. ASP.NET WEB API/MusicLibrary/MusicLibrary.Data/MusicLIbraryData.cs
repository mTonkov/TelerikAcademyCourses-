
using MusicLibrary.Data.Contracts;
using MusicLibrary.Models;
using System;
using System.Collections.Generic;
namespace MusicLibrary.Data
{
    public class MusicLibraryData : IMusicLibraryData
    {
        private IMusicLibraryDbContext context;
        private IDictionary<Type, object> repositories;

        public MusicLibraryData()
            : this(new MusicLibraryDbContext())
        {
        }

        public MusicLibraryData(IMusicLibraryDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Album> Albums
        {
            get
            {
                return this.GetRepository<Album>();
            }
        }

        public IRepository<Song> Songs
        {
            get
            {
                return this.GetRepository<Song>();
            }
        }

        public IRepository<Artist> Artists
        {
            get
            {
                return this.GetRepository<Artist>();
            }
        }


        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            var typeOfModel = typeof(T);
            if (!this.repositories.ContainsKey(typeOfModel))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeOfModel, Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeOfModel];
        }
    }
}
