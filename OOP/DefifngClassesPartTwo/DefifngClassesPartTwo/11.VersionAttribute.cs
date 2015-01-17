using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{        
    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Struct|AttributeTargets.Enum|AttributeTargets.Method|AttributeTargets.Interface)]

    public class VersionAttribute:Attribute
    {
        public int major { get; set; }
        public int minor { get; set; }

        public VersionAttribute(int mjr, int mnr) 
        {
            this.major = mjr;
            this.minor = mnr;
        }
    }
}
