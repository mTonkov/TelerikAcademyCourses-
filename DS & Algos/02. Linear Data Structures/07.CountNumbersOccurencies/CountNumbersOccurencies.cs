using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbersOccurencies
{/*Write a program that finds in given array of integers (all belonging to the range [0..1000]) how many times each of them occurs.
Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
2 -> 2 times
3 -> 4 times
4 -> 3 times
*/
    public class CountNumbersOccurencies
    {
        static void Main(string[] args)
        {
            var sequence = new List<int>(){3, 4, 4, 2, 3, 3, 4, 3, 2};
            sequence.Sort();

            var numberOccurenciesPairs = new Dictionary<int, int>();

            for (int i = 0; i < sequence.Count; i++)
            {
                int current = sequence[i];

                if (!numberOccurenciesPairs.ContainsKey(current))
                {
                    numberOccurenciesPairs.Add(current, 1);
                }
                else
                {
                    numberOccurenciesPairs[current]++;
                }
            }

            foreach (var pair in numberOccurenciesPairs)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
