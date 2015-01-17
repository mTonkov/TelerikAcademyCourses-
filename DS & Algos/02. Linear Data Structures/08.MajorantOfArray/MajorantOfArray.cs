using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MajorantOfArray
{/*
  * The majorant of an array of size N is a value that occurs in it at least N/2 + 1 times. 
    Write a program to find the majorant of given array (if exists). Example:
{2, 2, 3, 3, 2, 3, 4, 3, 3} -> 3
*/
    public class MajorantOfArray
    {
        static void Main(string[] args)
        {
            var sequence = new int[] { 2, 2, 3, 3, 2, 3, 4, 3, 3 };
            var sortedSequence = sequence.ToList<int>();
            sortedSequence.Sort();

            int current = 0;
            for (int i = 0; i < sortedSequence.Count; i++)
            {
                if (i == 0 || current != sortedSequence[i])
                {
                    current = sortedSequence[i];
                    int lastOccurence = sortedSequence.LastIndexOf(current);

                    if ((lastOccurence - i + 1) == sequence.Length / 2 + 1)
                    {
                        Console.WriteLine("The majorant is {0}", current);
                        break;
                    }
                }
            }
        }
    }
}
