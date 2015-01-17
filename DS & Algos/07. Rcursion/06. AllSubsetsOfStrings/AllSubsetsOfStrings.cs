using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AllSubsetsOfStrings
{/*Write a program for generating and printing all subsets of k strings from given set of strings.
	Example: s = {test, rock, fun}, k=2
	(test rock),  (test fun),  (rock fun)
*/
    class AllSubsetsOfStrings
    {
        static void Main()
        {
            int k = 2;
            string[] set = new string[] { "test", "rock", "fun" };
            string[] array = new string[k];

            FindSubsets(set, array, 0, 0);
        }

        private static void FindSubsets(string[] set, string[] array, int index, int start)
        {
            if (index == array.Length)
            {
                Console.WriteLine(string.Join("  ", array));
            }
            else
            {
                for (int i = start; i < set.Length; i++)
                {
                    array[index] = set[i];
                    FindSubsets(set, array, index + 1, start + 1);
                    start++;
                }
            }
        }
    }
}
