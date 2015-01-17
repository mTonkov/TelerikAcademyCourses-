using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.RemoveNegativeNumbers
{/*Write a program that removes from given sequence all negative numbers*/
    public class RemoveNegativeNumbers
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 2, 5, -6, 3, -8, -66, 4, 9 };

            for (int i = 0; i < sequence.Count; i++)
            {
                int num = sequence[i];
                if (num < 0)
                {
                    sequence.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(", ", sequence));
        }
    }
}
