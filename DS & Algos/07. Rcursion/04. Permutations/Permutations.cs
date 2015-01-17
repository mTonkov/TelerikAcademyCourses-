using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Permutations
{
    class Permutations
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i+1;
            }

            Permutate(array, n-1);
        }

        private static void Permutate(int[] array, int lastIndex)
        {
            if (lastIndex == 0)
            {
                Console.WriteLine(string.Join("  ", array));
            }
            else
            {
                Permutate(array, lastIndex - 1);

                for (int i = 0; i < lastIndex; i++)
                {
                    Swap(i, lastIndex, array);
                    Permutate(array, lastIndex - 1);
                    Swap(i, lastIndex, array);
                }
            }
        }

        private static void Swap(int firstIndex, int secondIndex, int[] array)
        {
            var temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}
