namespace HQPC_School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
        
    public class Course
    {
        const int MAX_STUDENTS_IN_COURSE = 30;

        private ICollection<Student> students;

        public Course()
        {
            this.Students = new List<Student>();
        }

        public Course(ICollection<Student> students)
        {
            this.Students = students;
        }

        public ICollection<Student> Students
        {
            get 
            { 
                return new List<Student>(this.students); 
            }
            set 
            {
                if (value.Count > MAX_STUDENTS_IN_COURSE)
                {
                    throw new ArgumentOutOfRangeException("Students in a course must be less than 30");
                }
                if (value == null)
                {
                    throw new NullReferenceException("The collection of students in a course cannot be null");
                }

                this.students = value; 
            }
        }

        public void AddStudent(Student student)
        {
            if (this.Students.Count==MAX_STUDENTS_IN_COURSE)
            {
                throw new InvalidOperationException("You cannot add student over the maximum number of 30 students in a course");
            }
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.students.Remove(student);
        }
    }
}
