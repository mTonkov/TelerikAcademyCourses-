using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace StudentSystem.Model
{
    public class Course
    {
        public ICollection<Student> students;
        public ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
        }

        [Key]
        public int CourseId { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }

        public int StudentId { get; set; }

        public virtual ICollection<Student> Students { get; set; }

        public int HomeworkId { get; set; }

        public virtual ICollection<Homework> Homeworks { get; set; }
    }
}
