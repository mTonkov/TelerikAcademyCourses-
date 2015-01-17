using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_Design_Patterns.Decorator
{
    public class Person : IHuman
    {
        public string Walk()
        {
            return "I am walking ";
        }
    }
}
