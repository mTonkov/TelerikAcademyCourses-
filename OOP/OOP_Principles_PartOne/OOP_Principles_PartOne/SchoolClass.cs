
namespace School
{
    using System;
    using System.Collections.Generic;

    public class SchoolClass
    {
        private List<Student> students;
        private List<Teacher> teachers;
        private string textId;

        public SchoolClass(string textId)
        {
            this.TextID = textId;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }
        public SchoolClass(string textId, List<Student> pupil, List<Teacher> tutor)
            : this(textId)
        {
            this.Students = pupil;
            this.Teachers = tutor;
        }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }
        public string TextID
        {
            get
            {
                return this.textId;
            }
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("You have not entered an ID for the class!");
                }
                this.textId = value;
            }
        }
        public string Comments { get; set; } // it is optional, that's why there is no use in a constructor
    }
}
