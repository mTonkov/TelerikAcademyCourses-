using _11.ForumSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ForumSystem.Data
{
    public class ForumSystemContext : DbContext
    {
        public ForumSystemContext()
            : base(Settings.Default.DBConnectionStr)
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Group> Groups { get; set; }

    }
}
