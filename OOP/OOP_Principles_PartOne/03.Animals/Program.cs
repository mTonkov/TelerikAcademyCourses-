using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
 * All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, name and sex. 
 * Kittens can be only female and tomcats can be only male. Each animal produces a specific sound. 
 * Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).*/
namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[] 
            {
            new Dog("Barry", 2, Gender.male),
            new Dog("Linda", 4, Gender.female),
            new Dog("Barry", 7, Gender.male),
            };

            Frog[] frogs = new Frog[]
            {
            new Frog("Larry", 2, Gender.male),
            new Frog("Burt", 1, Gender.male),
            new Frog("Nana", 3, Gender.female),
            };

            Kitten[] kittens = new Kitten[]
            {
            new Kitten("Lindsey", 6),
            new Kitten("Jinie", 2),
            new Kitten("Fluffy", 3),
            };

            Tomcat[] Tomcats = new Tomcat[]
            {
            new Tomcat("Jonnie", 4),
            new Tomcat("Lanselot", 1),
            new Tomcat("Arthur", 8),
            };

            var avgDogsAge = Animal.AverageAge(dogs);
            Console.WriteLine("{0:F1}", avgDogsAge);
            var avgFrogsAge = Animal.AverageAge(frogs);
            Console.WriteLine("{0:F1}", avgFrogsAge);
            var avgKittenAge = Animal.AverageAge(kittens);
            Console.WriteLine("{0:F1}", avgKittenAge);
            var avgTomAge = Animal.AverageAge(Tomcats);
            Console.WriteLine("{0:F1}", avgTomAge);
        }
    }
}
