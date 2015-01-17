
namespace Animals
{
    using System;

    public class Frog : Animal
    {
        private const string frogSound = "Kwuak, Kwuak";

        public Frog(string name, int age, Gender sex)
            : base(name, age, sex, frogSound)
        { }
    }
}
