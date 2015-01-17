
namespace CommonTypeSystem_Homework
{/*
  TASK 04
  Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value.
  * Override ToString() to display the information of a person and if age is not specified – to say so. 
  * Write a program to test this functionality.
*/
    using System;
    using System.Text;
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; set; }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            if (age!=null)
            {
                this.Age = (int)age;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(this.Name);
            if (this.Age>0)
            {
                result.AppendLine(this.Age.ToString());
            }
            else
            {
                result.AppendLine("No age specified!");
            }
            return result.ToString();
        }
    }
}
