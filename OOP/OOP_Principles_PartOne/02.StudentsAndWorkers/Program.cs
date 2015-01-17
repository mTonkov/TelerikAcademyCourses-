using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> 
            { 
                new Student("Serafim", "Popov", 2),
                new Student("Gosho", "Ivanov", 5),
                new Student("Misho", "Evgeniev", 4),
                new Student("Ivan", "Petrov", 7),
                new Student("Ivan", "Ivanov", 6),
                new Student("Pesho", "Ivanov", 6),
                new Student("Ivan", "Georgiev", 9),  
                new Student("Ivo", "Andonov", 12),
                new Student("Rosen", "Gatsov", 12),
                new Student("Ivan", "Ivanov", 10),
            };

            List<Worker> workers = new List<Worker>
            {
                new Worker("Deyan", "Donkov", 500, 8),
                new Worker("Petar", "Mihalev", 700, 8),
                new Worker("Daniel", "Tsonev", 750, 8),
                new Worker("Dimitar", "Georgiev", 570, 8),
                new Worker("Veselin", "Andreev", 450, 8),
                new Worker("Ivan", "Aleksandrov", 1500, 8),
                new Worker("Emil", "Vasilev", 2500, 8),
                new Worker("Vladimir", "Vladimirov", 900, 8),
                new Worker("Misho", "Lazarov", 2500, 8),
                new Worker("Gosho", "Naidenov", 1350, 8),
            };

            var sortedStudents = students.OrderBy(x => x.Grade); //using Lambda expressions
            foreach (var st in sortedStudents)
            {
                Console.WriteLine(st);
            }

            var sortedWorkers =       //using LINQ
                from w in workers
                orderby w.MoneyPerHour() descending
                select w;
            foreach (var w in sortedWorkers)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();
            Console.WriteLine();

            var mergedSort = students.Union<Human>(workers).ToList().OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var sw in mergedSort)
            {
                Console.WriteLine(sw);
            }
        }
    }
}
