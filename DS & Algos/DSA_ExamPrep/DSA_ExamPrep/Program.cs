using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ExamPrep
{
    class Program
    {
        static Figure[] framesArray;
        static string[] tempResults;
        static List<string> finalResults;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            framesArray = new Figure[n];
            tempResults = new string[n];
            finalResults = new List<string>();

            for (int i = 0; i < n; i++)
            {
                var pair = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var currentFigure = new Figure
                {
                    Width = int.Parse(pair[0]),
                    Height = int.Parse(pair[1])
                };

                framesArray[i] = currentFigure;
            }

            GeneratePermutations(framesArray, 0);

            finalResults.Sort();

            Console.WriteLine(finalResults.Count);
            foreach (var item in finalResults)
            {
                Console.WriteLine(item);
            }
        }


        static void GeneratePermutations(Figure[] arr, int k)
        {
            if (k >= arr.Length)
            {
                AddFlipped(arr, 0);
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

        private static void AddFlipped(Figure[] arr, int p)
        {
            if (p >= arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    tempResults[i] = arr[i].ToString();
                }

                finalResults.Add(string.Join(" | ", tempResults));
                tempResults[p - 1] = arr[p - 1].Flip().ToString();
                finalResults.Add(string.Join(" | ", tempResults));
                arr[p - 1].Flip();
            }
            else
            {
                arr[p].Flip();
                AddFlipped(arr, p + 1);
                arr[p].Flip();
            }
        }

        static void Print<T>(T[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        static void Swap<T>(ref T first, ref T second)
        {
            T oldFirst = first;
            first = second;
            second = oldFirst;
        }

    }
}
