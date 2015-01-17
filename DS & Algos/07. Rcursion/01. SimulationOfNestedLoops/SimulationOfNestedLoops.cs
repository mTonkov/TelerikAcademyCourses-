using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SimulationOfNestedLoops
{/*Write a recursive program that simulates the execution of n nested loops from 1 to n. Examples:
                           1 1 1
                           1 1 2
                           1 1 3
         1 1               1 2 1
n=2  ->  1 2      n=3  ->  ...
         2 1               3 2 3
         2 2               3 3 1
                           3 3 2
                           3 3 3
*/
    class SimulationOfNestedLoops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            SimulateLoops(n, 0, array);
        }

        private static void SimulateLoops(int n, int index, int[] array)
        {
            if (index == array.Length)
            {
                Print(array);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    array[index] = i + 1;
                    SimulateLoops(n, index + 1, array);
                }
            }
        }

        private static void Print(int[] array)
        {
            Console.WriteLine(string.Join("  ", array));
        }
    }
}
