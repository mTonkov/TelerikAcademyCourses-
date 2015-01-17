namespace HCPC_NamingIdentifiers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class People
    {
        public enum Gender
        {
            Man, Woman
        }

        public void CreatePerson(int personID)
        {
            Person person = new Person();
            person.Age = personID;

            if (personID % 2 == 0)
            {
                person.Name = "Gosho";
                person.Gender = Gender.Man;
            }
            else
            {
                person.Name = "Maria";
                person.Gender = Gender.Woman;
            }
        }

        public class Person
        {
            public Gender Gender { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}