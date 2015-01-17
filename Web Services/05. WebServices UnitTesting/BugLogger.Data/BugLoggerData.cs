using BugLogger.Data.Contracts;
using BugLogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugLogger.Data
{
    public class BugLoggerData : IBugLoggerData
    {
        private IBugLoggerDbContext context;
        private IDictionary<Type, object> repositories;

        public BugLoggerData()
            : this(new BugLoggerDbContext())
        {
        }

        public BugLoggerData(IBugLoggerDbContext context)
        {
            this.context = context;
            this.repositories = new Dictionary<Type, object>();
        }

        public IRepository<Bug> Bugs
        {
            get
            {
                return this.GetRepository<Bug>();
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
