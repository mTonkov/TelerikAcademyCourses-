using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.RemoveWithOddOccurencies
{/*Write a program that removes from given sequence all numbers that occur odd number of times. Example:
{4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
*/
    public class RemoveWithOddOccurencies
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            var sortedSequence = sequence.ToList<int>();
            sortedSequence.Sort();

            int current = 0;
            for (int i = 0; i < sortedSequence.Count; i++)
            {
                if (i == 0 || current != sortedSequence[i])
                {
                    current = sortedSequence[i];
                    int lastOccurence = sortedSequence.LastIndexOf(current);

                    if ((lastOccurence - i + 1) % 2 != 0)
                    {
                        while (sequence.IndexOf(current) >= 0)
                        {
                            sequence.Remove(current);
                        }
                    }
                }
            }

            Console.WriteLine("Only numbers that occur EVEN number of times: {0}", string.Join(", ", sequence));
        }
    }
}
