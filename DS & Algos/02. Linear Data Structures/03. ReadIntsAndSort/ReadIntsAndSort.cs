using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ReadIntsAndSort
{
    public class ReadIntsAndSort
    {/*Write a program that reads a sequence of integers (List<int>) ending with an empty line 
      * and sorts them in an increasing order*/
        static void Main(string[] args)
        {
            var sequence = new List<int>();

            while (true)
            {
                string inputRow = Console.ReadLine();

                if (string.IsNullOrEmpty(inputRow))
                {
                    break;
                }

                int number = int.Parse(inputRow);
                sequence.Add(number);
            }

            sequence.Sort();
            Console.WriteLine("The sorted sequence is: {0}", string.Join(", ", sequence));
        }
    }
}
