
namespace Animals
{
    using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Animal(string name, int age, Gender sex, string sound)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
            this.Sound = sound;
        }

        public int Age
        {
            get
            { return this.age; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age should be a positive number!");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get
            { return this.name; }
            protected set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("You should give that little fellow some name");
                }
                this.name = value;
            }
        }
        public Gender Sex { get; protected set; }
        public string Sound { get; protected set; }

         
        public void MakeSound(string sound)
        {
            if (string.IsNullOrEmpty(sound) || string.IsNullOrWhiteSpace(sound))
            {
                Console.WriteLine("\"Silence...\"");
            }
            Console.WriteLine(sound);
        }

        public static double AverageAge(IEnumerable<Animal> animals)
        {
            var avAge =
                from a in animals
                select a.Age;
                        
            return avAge.Average();
        }
    }
}
