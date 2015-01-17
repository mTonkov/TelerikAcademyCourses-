using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Linear_Data_Structures
{
    public class Program
    {
        static void Main(string[] args)
        {/*
           Write a program that reads from the console a sequence of positive integer numbers. 
           The sequence ends when empty line is entered.
           Calculate and print the sum and average of the elements of the sequence. 
           Keep the sequence in List<int>.
*/
            int sum = 0;
            var sequence = new List<int>();

            while (true)
            {
                string inputRow = Console.ReadLine();

                if (string.IsNullOrEmpty(inputRow))
                {
                    break;
                }

                int number = int.Parse(inputRow);
                sum += number;
                sequence.Add(number);
            }

            Console.WriteLine("The sum of the numbers is {0}, and the average is {1}", sum, (double)sum/2);
        }
    }
}
