using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresEfficiency
{/*A text file students.txt holds information about students and their courses in the following format:
Kiril  | Ivanov   | C#
Stefka | Nikolova | SQL
Stela  | Mineva   | Java
Milena | Petrova  | C#
Ivan   | Grigorov | C#
Ivan   | Kolev    | SQL

	Using SortedDictionary<K,T> print the courses in alphabetical order and for each of them prints the students ordered by family and then by name:
C#: Ivan Grigorov, Kiril Ivanov, Milena Petrova
Java: Stela Mineva
SQL: Ivan Kolev, Stefka Nikolova

*/
    public class StudentsInCoursesOrdered
    {
        public static void Main(string[] args)
        {
            var reader = new StreamReader("..\\..\\students.txt");
            var coursesAndNames = new SortedDictionary<string, SortedDictionary<string, List<string>>>();
            using (reader)
            {
                string line = reader.ReadLine();
                while (!string.IsNullOrEmpty(line))
                {
                    var lineInParts = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                    var firstName = lineInParts[0];
                    var lastName = lineInParts[1];
                    var course = lineInParts[2];

                    if (!coursesAndNames.ContainsKey(course))
                    {
                        coursesAndNames[course] = new SortedDictionary<string, List<string>>();
                    }

                    if (!coursesAndNames[course].ContainsKey(lastName))
                    {
                        coursesAndNames[course][lastName] = new List<string>();
                    }
                    coursesAndNames[course][lastName].Add(firstName);

                    line = reader.ReadLine();
                }
            }

            foreach (var courseAndNamePair in coursesAndNames)
            {
                var nameBuilder = new List<string>();
                foreach (var names in courseAndNamePair.Value)
                {
                    names.Value.Sort();
                    foreach (var firstName in names.Value)
                    {
                        nameBuilder.Add(firstName + " " + names.Key);
                    }
                }

                Console.WriteLine(courseAndNamePair.Key + ": " + string.Join(", ", nameBuilder));
            }
        }
    }
}
