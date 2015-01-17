using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTypeSystem_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            var st1 = new Student("Ivan", "Petrov", "Ivanov", 123654987, "Sofia, Bulgaria", "asd@asd.bg", "OOP", Specialty.SoftwareEngineering, Faculty.ComputerScience, University.NBU);

            Console.WriteLine(st1);

            var st2 = st1.Clone(); //task 02
            Console.WriteLine(st2);

            (st2 as Student).SocialSecurityNumber = 123654980;//task 03

            Console.WriteLine(st1.CompareTo(st2 as Student));

            var p = new Person("Gosho"); //task 04
            Console.WriteLine(p);
            p.Age = 24;
            Console.WriteLine(p);

            ulong inputNumber = 8; // this is a number, which 3rd bit is '1'
            var bits = new BitArray64(inputNumber);

            Console.WriteLine(bits[3]); //output: '1' 
        }
    }
}
