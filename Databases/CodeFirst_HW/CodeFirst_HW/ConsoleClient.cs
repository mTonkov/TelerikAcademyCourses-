using StudentSystem.Data;
using StudentSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_HW
{
   public class ConsoleClient
    {
        static void Main(string[] args)
        {
            var db = new StudentSystemContext();

            db.Courses.Add(new Course
            {
                Name = "DataBases"
            });


            for (int i = 0; i < 10; i++)
            {
                db.Students.Add(new Student
                {
                    FirstName = "Student" ,
                    LastName = "Number "+i
                });
            }
            db.SaveChanges();

            var courses = db.Courses;

            foreach (var item in courses)
            {
                Console.WriteLine(item.CourseId + ": " + item.Name);
            }
        }
    }
}
