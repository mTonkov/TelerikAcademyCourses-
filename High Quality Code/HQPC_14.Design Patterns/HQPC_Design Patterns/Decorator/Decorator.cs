using System;
using System.Collections.Generic;
using System.Text;

namespace HQPC_Design_Patterns.Decorator
{
    public class Decorator : IHuman
    {
        IHuman decoratedPerson;

        public Decorator(IHuman person)
        {
            decoratedPerson = person;
        }

        public string Walk()
        {
            string decoratedWalk = decoratedPerson.Walk();
            decoratedWalk += "and it is raining!";
            return decoratedWalk;
        }
    }
}