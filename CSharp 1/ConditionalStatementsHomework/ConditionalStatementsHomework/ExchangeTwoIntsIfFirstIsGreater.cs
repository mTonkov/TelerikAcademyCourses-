using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeTwoIntsIfFirstIsGreater
{
    class ExchangeTwoIntsIfFirstIsGreater
    {
        static void Main(string[] args)
        {
            // Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one

            Console.WriteLine("Please enter two integer numbers");

            int firstNum = int.Parse(Console.ReadLine());

            int secondNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum)
            {
                int exchange = secondNum;
                secondNum = firstNum;
                firstNum = exchange;
            }

            Console.WriteLine("The bigger number is {0}", secondNum);
        }
    }
}
