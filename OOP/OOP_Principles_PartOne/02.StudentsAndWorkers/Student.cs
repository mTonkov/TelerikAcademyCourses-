
namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        private int grade;

        public Student(string fName, string lName)
            : base(fName, lName)
        {}

        public Student(string fName, string lName, int gr)
            : this(fName, lName)
        {             
            this.grade = gr;
        }

        public int Grade
        {
            get
            { return this.grade; }
            private set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentOutOfRangeException("Grades in Bulgarian schools are between 1 and 13. Please enter a correct value");
                }
                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format(FirstName.PadRight(10) + " " + LastName.PadRight(10) + " " + Grade.ToString().PadLeft(2));
        }
    }
}
