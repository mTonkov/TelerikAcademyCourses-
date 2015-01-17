using BugLogger.Data.Migrations;
using BugLogger.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugLogger.Data
{
    public class BugLoggerDbContext : DbContext, IBugLoggerDbContext
    {
        public BugLoggerDbContext()
            : base("BugLoggerConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BugLoggerDbContext, Configuration>());
        }

        public IDbSet<Bug> Bugs { get; set; }

        public new void SaveChanges()
        {
            base.SaveChanges();
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }

    }
}
