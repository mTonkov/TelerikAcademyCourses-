using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dividers
{
    class PermutationWithLeastDividers
    {
        private static int dividersCount = 0;
        private static int minimumDividersCount = int.MaxValue;
        private static List<int> numbersWithMinimumDividers = new List<int>();

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            GeneratePermutations(array, 0);

            Console.WriteLine(numbersWithMinimumDividers.Min());
        }

        static void GeneratePermutations<T>(T[] arr, int k)
        {
            if (k >= arr.Length)
            {
                dividersCount = 0;
                var number = int.Parse(string.Join("", arr));
                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        dividersCount++;
                    }
                }
                if (dividersCount < minimumDividersCount)
                {
                    numbersWithMinimumDividers.Clear();
                    numbersWithMinimumDividers.Add(number);
                    minimumDividersCount = dividersCount;
                }
                else if (dividersCount == minimumDividersCount)
                {
                    numbersWithMinimumDividers.Add(number);
                }
            }
            else
            {
                GeneratePermutations(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    GeneratePermutations(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

    }
}
