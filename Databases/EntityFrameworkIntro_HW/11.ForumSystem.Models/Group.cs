using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ForumSystem.Models
{
    public class Group
    {
        private ICollection<User> users;

        public Group()
        {
            this.users = new HashSet<User>();
        }

        public int GroupId { get; set; }

        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
