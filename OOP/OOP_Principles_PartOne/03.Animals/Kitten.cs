


namespace Animals
{
    using System;
    public class Kitten:Cat
    {
        private const Gender kittenSex = Gender.female;

        public Kitten(string name, int age)
            : base(name, age, kittenSex)
        { }
    }
}
