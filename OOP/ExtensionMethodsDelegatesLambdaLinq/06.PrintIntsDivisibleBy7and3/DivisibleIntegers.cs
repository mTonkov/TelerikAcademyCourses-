using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
 * Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ*/
namespace PrintIntsDivisibleBy7and3
{
    class DivisibleIntegers
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 6, 15, 18, 20, 21 };

            var result = numbers.FindAll(x => (x % 3) == 0 || (x % 7) == 0);

            foreach (var number in result)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine(); 

            // Using LINQ, but the number should be divisible by 3 and 7 inthe same time:
            Console.WriteLine("Using LINQ, but the number should be divisible by 3 and 7 inthe same time:");
            var linqResult =
                from n in numbers
                where (n % 3) == 0 && (n % 7) == 0
                select n;

            foreach (var number in linqResult)
            {
                Console.WriteLine(number);
            }
        }
    }
}
