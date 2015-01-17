using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.*/
namespace GetNamesInAgeRange
{
    class GetStudentsNames
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

            var studentsNames =
                from st in students
                where st.age >= 18 && st.age <= 24
                select st.firstName + " " + st.lastName;

            foreach (var student in studentsNames)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
