using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestVariable
{
    class GreatestVariable
    {
        static void Main(string[] args)
        { //Write a program that finds the greatest of given 5 variables.

            Console.WriteLine("How many numbers you would like to enter?"); 
            int count = int.Parse(Console.ReadLine());
            //      or         
            //int count = 5;
            int input = 0;
            int greatest = input;
            for (int i = 0; i < count; i++) // every time the loop runs, it asks the user to input data. 
            {                   //each input is compared with the greatest one found by the current iteration and the greater one is stored
                Console.Write("Enter a number : ");
                input = int.Parse(Console.ReadLine());
                if (input>greatest)
                {
                    greatest = input;
                }
            }
                                         
            Console.WriteLine("The greatest number of the {0} numbers you entered is: {1}", count, greatest);
        }
    }
}
