

namespace Animals
{
    using System;

    public class Tomcat : Cat
    {
        private const Gender tomSex = Gender.male;

        public Tomcat(string name, int age)
            : base(name, age, tomSex)
        { }
    }
}
