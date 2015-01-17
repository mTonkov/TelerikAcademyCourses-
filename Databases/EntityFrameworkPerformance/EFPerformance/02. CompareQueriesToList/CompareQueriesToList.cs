using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikAcademy.Model;

namespace _02.CompareQueriesToList
{/*Using Entity Framework write a query that selects all employees from the Telerik Academy database, then invokes ToList(), then selects their addresses, then invokes ToList(), then selects their towns, then invokes ToList() and finally checks whether the town is "Sofia". Rewrite the same in more optimized way and compare the performance.
*/
    public class CompareQueriesToList
    {
        public static void Main()
        {
            var db = new TelerikAcademyDB();

            //var employees = db.Employees.ToList().Select(e => e.Address).ToList().Select(a => a.Town).ToList().Where(t => t.Name == "Sofia");

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine(employee.Name);
            //}

            //optimized
            var employees = db.Employees
                              .Select(e => new
                              {
                                  town = e.Address.Town.Name
                              })
                              .Where(e => e.town == "Sofia");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.town);
            }
        }
    }
}
