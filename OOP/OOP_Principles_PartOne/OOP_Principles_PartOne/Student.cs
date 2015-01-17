
namespace School
{
    using System;

    public class Student : People
    {
        private int id;

        public Student(string name, int id)
            : base(name)
        {
            this.Name = name;
            this.ID = id;
        }
        public Student(string name, int id, string comments)
            : this(name, id)
        {
            this.Comments = comments;
        }


        public int ID
        {
            get
            {
                return this.id;
            }
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException("Student IDs cannot be less than \"1\"");
                }
                this.id = value;
            }
        }
        public string Comments { get; set; }
    }
}
