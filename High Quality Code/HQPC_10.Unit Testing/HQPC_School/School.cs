namespace HQPC_School
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class School
    {
        private ICollection<Course> courses;

        public School()
        {
            this.Courses = new List<Course>();
        }

        public School(ICollection<Course> courses)
        {
            this.Courses = courses;
        }

        public ICollection<Course> Courses
        {
            get 
            { 
                return new List<Course>(courses); 
            }
            set 
            {
                if (value==null)
                {
                    throw new NullReferenceException("The school cannot contain null courses");
                }

                this.courses = value; 
            }
        }        
    }
}
