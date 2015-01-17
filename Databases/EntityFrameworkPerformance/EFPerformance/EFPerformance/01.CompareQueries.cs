using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Model;

namespace EFPerformance
{/*Using Entity Framework write a SQL query to select all employees from the Telerik Academy database and later print their name, department and town. 
  * Try the both variants: with and without .Include(…). 
  * Compare the number of executed SQL statements and the performance.
*/
    public class CompareQueries
    {
        public static void Main()
        {
            var db = new TelerikAcademyDB();

            //var employees = db.Employees.Where(e => e.FirstName.StartsWith("A"));

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(
            //        employee.FirstName + " " + employee.LastName +
            //        " works in the " + employee.Department.Name + " department and lives in " + employee.Address.Town);
            //}



            //Projection with Select
            //var employees = db.Employees.Where(e => e.FirstName.StartsWith("A"))
            //                            .Select(e => new
            //                            {
            //                                e.FirstName,
            //                                e.LastName,
            //                                department = e.Department.Name,
            //                                town = e.Address.Town.Name
            //                            });

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.FirstName + " " + employee.LastName +
            //        " works in the " + employee.department + " department and lives in " + employee.town);
            //}


            var employees = db.Employees.Include("Department").Include("Address");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName +
                    " works in the " + employee.Department.Name + " department and lives in " + employee.Address.Town.Name);
            }
        }
    }
}
