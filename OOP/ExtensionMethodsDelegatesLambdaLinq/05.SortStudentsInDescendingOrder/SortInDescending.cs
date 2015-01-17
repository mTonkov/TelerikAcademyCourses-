using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the 
 * students by first name and last name in descending order. Rewrite the same with LINQ.*/
namespace SortStudentsInDescendingOrder
{
    class SortInDescending
    {
        static void Main(string[] args)
        {
            var students = new[]{
                new{firstName = "Ivan", lastName="Ivanov", age = 20},
                new{firstName = "Ivan", lastName="Petrov", age = 23},
                new{firstName = "Peter", lastName="Metodiev", age = 32},
                new{firstName = "Yana", lastName="Zaharieva", age = 29},
                new{firstName = "Zhana", lastName="Stoyanova", age = 24},
                new{firstName = "Unufri", lastName="Prokopiev", age = 21},
                };

            var sortedStudents = students.OrderByDescending(st => st.firstName).ThenByDescending(st => st.lastName).Select
                (st => st.firstName+" "+st.lastName);

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Using LINQ:"); Console.WriteLine();

            var linqSort =
                from st in students
                orderby st.firstName descending, st.lastName descending                
                select st.firstName +" "+st.lastName;

            foreach (var student in linqSort)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
