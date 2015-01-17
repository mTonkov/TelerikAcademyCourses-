using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Dictionaries_HashTables_Sets
{/*01.Write a program that counts in a given array of double values the number of occurrences of each value. Use Dictionary<TKey,TValue>.
Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
-2.5  2 times
3  4 times
4  3 times
*/
    public class CountOccurencies
    {
        public static void Main()
        {
            double[] array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };

            var counter = new Dictionary<double, int>();

            for (int i = 0; i < array.Length; i++)
            {
                double currentNumber = array[i];
                if (!counter.ContainsKey(currentNumber))
                {
                    counter[currentNumber] = 0;
                }

                counter[currentNumber]++;
            }

            foreach (var pair in counter)
            {
                Console.WriteLine("The number {0} is contained {1} time(s)", pair.Key, pair.Value);
            }
        }
    }
}
