
namespace School
{
    using System;
    using System.Collections.Generic;

    public class Teacher : People
    {
        private List<Discipline> courseSet;


        public Teacher(string name)
            : base(name)
        {
            this.courseSet = new List<Discipline>();
        }
        public Teacher(string name, List<Discipline> disciplines)
            : this(name)
        {
            this.courseSet = disciplines;
        }


        public List<Discipline> TaughtDisciplines
        {
            get
            {
                return new List<Discipline>(this.courseSet);
            }
        }
        public string Comments { get; set; }


        public void AddDiscipline(Discipline course)//Method to add disciplines
        {
            this.courseSet.Add(course);
        }
    }
}
