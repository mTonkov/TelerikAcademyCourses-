using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStudents
{
    class Student
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Your name should contain only letters");
                    }
                }
                firstName = value;
            }
        }
        
        public string LastName
        {
            get { return lastName; }
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    if (!Char.IsLetter(value[i]))
                    {
                        throw new ArgumentException("Your name should contain only letters");
                    }
                }
                lastName = value;
            }
        }

        public int FacultyNum { get; set; }
        public long Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public int GroupNumber { get; set; }

        public Student(string firstName, string lastName, int faculty, long tel, string email, List<int> marks, int groups)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNum = faculty;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groups;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendFormat("{0} {1}, faculty number {2}, tel {3}, email: {4}, marks: ({5})", this.FirstName, this.LastName, this.FacultyNum, this.Tel, this.Email, string.Join(",", this.Marks));
            return sb.ToString();
        }
    }
}
