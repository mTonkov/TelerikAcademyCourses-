using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ForumSystem.Models
{
    public class User
    {
        public int UserId { get; set; }

        public string Nickname { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
