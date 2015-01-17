using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SequenceOfEqualElements
{
    public class SequenceOfEqualElements
    {/*Write a method that finds the longest subsequence of equal numbers in given List<int> 
      * and returns the result as new List<int>. 
      * Write a program to test whether the method works correctly.
*/
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

            var longestSequence = GetEqualNumbers(sequence);

            Console.WriteLine("The longest sequence of repeating elements is: {0}", string.Join(", ", longestSequence));
        }

        public static List<int> GetEqualNumbers(List<int> sequence)
        {
            int maxSequenceCount = 0;
            int currentSequenceCount = 0;
            int maxSequenceStart = 0;
            int currentSequenceStart = 0;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (currentSequenceCount > maxSequenceCount)
                {
                    maxSequenceCount = currentSequenceCount;
                    maxSequenceStart = currentSequenceStart;
                }

                if (sequence[i] == sequence[i - 1])
                {
                    currentSequenceCount++;
                }
                else
                {
                    currentSequenceCount = 1;
                    currentSequenceStart = i;
                }
            }

            var resultSequence = sequence.GetRange(maxSequenceStart, maxSequenceCount);
            return new List<int>(resultSequence);
        }
    }
}
