
namespace Animals
{
    using System;
    
    public class Dog : Animal
    {
        private const string bark = "Ruff, Ruff";

        public Dog(string name, int age, Gender sex)
            : base(name, age, sex, bark)
        { }
    }
}
