using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frames_v._2
{
    class Program
    {
        static IList<string> frames;
        static IList<string> finalResults;
        static int k;
        static string[] arr;
        static bool[] used;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            k = n;

            frames = new List<string>();
            arr = new string[k];
            finalResults = new List<string>();

            for (int i = 0; i < 2 * n; i += 2)
            {
                var pair = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                frames.Add("(" + string.Join(", ", pair) + ")");
                if (pair[0]!=pair[1])
                {
                frames.Add("(" + string.Join(", ", pair.Reverse()) + ")");
                }
            }
            used = new bool[frames.Count];

            //GenerateCombinationsNoRepetitions(0, 0);
            GenerateVariationsNoRepetitions(0);

            finalResults.OrderBy(p => p);

            Console.WriteLine(finalResults.Count);
            foreach (var item in finalResults)
            {
                Console.WriteLine(item);
            }
        }

        //static void GenerateCombinationsNoRepetitions(int index, int start)
        //{
        //    if (index >= k)
        //    {
        //        finalResults.Add(string.Join(" | ", arr));
        //    }
        //    else
        //    {
        //        for (int i = start; i < frames.Count; i++)
        //        {
        //            arr[index] = frames[i];
        //            GenerateCombinationsNoRepetitions(index + 1, i + 1);
        //        }
        //    }
        //}

        static void GenerateVariationsNoRepetitions(int index)
        {
            if (index >= k)
            {
                finalResults.Add(string.Join(" | ", arr));
            }
            else
            {
                for (int i = 0; i < frames.Count; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = frames[i];
                        GenerateVariationsNoRepetitions(index + 1);
                        used[i] = false;
                    }
                }
            }
        }

    }
}
