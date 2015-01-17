using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugLogger.Models
{
    public class Bug
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime LogDate { get; set; }

        public Status BugStatus { get; set; }
    }
}
