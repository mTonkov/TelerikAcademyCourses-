using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CombinationsWithoutDuplicates
{/*Modify the previous program to skip duplicates:
n=4, k=2  (1 2), (1 3), (1 4), (2 3), (2 4), (3 4)
*/
    class CombinationsWithoutDuplicates
    {
        static void Main()
        {
            Console.WriteLine("Insert a value for 'k'");
            int k = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert a value for 'n'");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[k];

            SimulateLoops(n, 0, 1, array);
        }

        private static void SimulateLoops(int n, int index, int start, int[] array)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    array[index] = i;
                    SimulateLoops(n, index + 1, i+1, array);
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine(string.Join("  ", array));
        }
    }
}
