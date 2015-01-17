using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace StudentSystem.Model
{
   public class Homework
   {
       public ICollection<Student> students ;
       public ICollection<Course> courses;

       public Homework()
       {
           this.students = new HashSet<Student>();
           this.courses = new HashSet<Course>();
       }
       [Key]
        public int HomeworkId { get; set; }

        public string Content { get; set; }
       
        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public int CourseId { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
