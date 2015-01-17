using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_School
{
    public class Student
    {
        private string name;
        private int idNumber;

        public Student(string name, int id)
        {
            this.Name = name;
            this.IDNumber = id;
        }

        public string Name
        {
            get 
            { 
                return this.name;
            }
            private set 
            {
                if (string.IsNullOrEmpty(value) || value.Length<5)
                {
                    throw new ArgumentException("You should pass a valid name for the student");
                }

                this.name = value; 
            }
        }

        public int IDNumber
        {
            get 
            { 
                return this.idNumber; 
            }
            private set 
            {
                if (value<10000 || value>99999)
                {
                    throw new ArgumentOutOfRangeException("The student's ID number should be a unique value in the range 10000-99999");
                }

                this.idNumber = value; 
            }
        }        
    }
}
