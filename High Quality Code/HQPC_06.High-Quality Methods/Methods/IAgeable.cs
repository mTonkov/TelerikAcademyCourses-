using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    public interface IAgeable
    {        
        public DateTime DateOfBirth { get; set; }
        
        public bool IsOlderThan();
    }
}
