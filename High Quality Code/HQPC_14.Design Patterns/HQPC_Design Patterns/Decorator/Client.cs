using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_Design_Patterns.Decorator
{
    public class Client
    {
        static void Display(string s, IHuman person)
        {
            Console.WriteLine(s + person.Walk());
        }

        public static void Main()
        {
            Console.WriteLine("Decorator Pattern\n");

            IHuman person = new Person();
            Display("Basic person: ", person);
            Display("Decorated : ", new Decorator(person));
            Console.ReadLine();
        }
    }
}
