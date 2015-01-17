using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Variations
{/*Write a recursive program for generating and printing all ordered k-element subsets from n-element set (variations Vkn).
	Example: n=3, k=2, set = {hi, a, b} =>
	(hi hi), (hi a), (hi b), (a hi), (a a), (a b), (b hi), (b a), (b b)
*/
    class Variations
    {
        static void Main(string[] args)
        {
            int n = 3;
            int k = 2;

            string[] set = new string[] { "hi", "a", "b" };
            string[] array = new string[k];

            Variate(array, set, 0);
        }

        private static void Variate(string[] arr, string[] set, int index)
        {
            if (index == arr.Length)
            {
                Console.WriteLine(string.Join("  ", arr));
            }
            else
            {
                for (int i = 0; i < set.Length; i++)
                {
                    arr[index] = set[i];
                    Variate(arr, set, index + 1);
                }
            }
        }
    }
}
