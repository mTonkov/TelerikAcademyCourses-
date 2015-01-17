
namespace Animals
{
    using System;

    public abstract class Cat : Animal
    {
        private const string catSound = "Meow";

        public Cat(string name, int age, Gender sex)
            : base(name, age, sex, catSound)
        {
            this.Sound = catSound;
        }

    }
}
