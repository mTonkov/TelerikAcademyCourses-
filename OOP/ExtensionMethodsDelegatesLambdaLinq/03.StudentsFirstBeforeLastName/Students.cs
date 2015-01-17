using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a method that from a given array of students finds all students whose first name is before its last name alphabetically. 
 * Use LINQ query operators*/

namespace StudentsFirstBeforeLastName
{
    class Students
    {
        static void Main(string[] args)
        {
            var students = new[]{
                new{firstName = "Ivan", lastName="Ivanov", age = 20},
                new{firstName = "Ivan", lastName="Petrov", age = 23},
                new{firstName = "Peter", lastName="Metodiev", age = 32},
                new{firstName = "Yana", lastName="Zaharieva", age = 29},
                new{firstName = "Zhana", lastName="Stoyanova", age = 24},
                };

// LAMBDA version:
            //var sortedStudents = students.Where(st => st.firstName.CompareTo(st.lastName) < 0)
            //    .Select(st => st.firstName + " " + st.lastName);

            var sortedStudents =
                from st in students
                where st.firstName.CompareTo(st.lastName) < 0
                select st.firstName + " " + st.lastName;

            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
