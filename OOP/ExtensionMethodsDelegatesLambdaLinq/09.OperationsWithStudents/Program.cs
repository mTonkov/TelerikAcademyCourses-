using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStudents
{
    /*9. Create a class student with properties FirstName, LastName, FN, Tel, Email, Marks (a List<int>), GroupNumber. 
     * Create a List<Student> with sample students. Select only the students that are from group number 2. Use LINQ query.
     * Order the students by FirstName.*/
    class FilterandChooseStudents
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Ivan", "Ivanov", 542, 054654321, "iv.iv@yahoo.bg", new List<int> { 2, 2, 4 }, 1));
            students.Add(new Student("Pesho", "Ivanov", 231, 029696212, "p.iv@gmail.bg", new List<int> { 6, 6, 4 }, 2));
            students.Add(new Student("Ivan", "Dimitrov", 988, 068654314, "iv.d@abv.bg", new List<int> { 2, 5, 4 }, 2));

            var selected =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;

            foreach (var st in selected)
            {
                Console.WriteLine(st);
            }

            //Task 10
            /*Implement the previous using the same query expressed with extension methods.*/
            Console.WriteLine();
            Console.WriteLine("Task 10:");
            var selectedExtensionMethod = students.FindAll(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            foreach (var st in selectedExtensionMethod)
            {
                Console.WriteLine(st);
            }

            /*Task 11
             Extract all students that have email in abv.bg. Use string methods and LINQ*/

            var abvEmails =
                from st in students
                where st.Email.Contains("@abv.bg")
                select st;
            Console.WriteLine();
            Console.WriteLine("Task 11:");
            foreach (var st in abvEmails)
            {
                Console.WriteLine(st);
            }


            /*Task12
             Extract all students with phones in Sofia. Use LINQ*/

            var sofiaTel =
                from a in students
                where a.Tel.ToString().PadLeft(a.Tel.ToString().Length + 1, '0').StartsWith("02")
                select a;

            Console.WriteLine();
            Console.WriteLine("Task 12:");
            foreach (var st in sofiaTel)
            {
                Console.WriteLine(st);
            }

            /*task13
             Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks. Use LINQ*/
            Console.WriteLine();
            Console.WriteLine("Task 13:");
            var excellentStudent =
                from st in students
                where st.Marks.Contains(6)
                select new { FullName = (st.FirstName + " " + st.LastName), Marks = string.Join(",", st.Marks) };

            foreach (var stud in excellentStudent)
            {
                Console.WriteLine(stud);
            }

            /*Task 14
             Write down a similar program that extracts the students with exactly  two marks "2". Use extension methods*/

            Console.WriteLine();
            Console.WriteLine("Task 14:");
            var poorMarks = students.FindAll(x => x.Marks.Count(y => y == 2) == 2);
            
            foreach (var stud in poorMarks)
            {
                Console.WriteLine(stud);
            }

            //Sorry! Not Enough time for the rest tasks...
        }
    }
}
