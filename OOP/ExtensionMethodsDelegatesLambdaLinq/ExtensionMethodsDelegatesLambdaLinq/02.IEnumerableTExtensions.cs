using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLinq
{
    /*Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max, average.
*/
    public static class IEnumerableExtensions
    {
        public static T Summm<T>(this IEnumerable<T> array)
            where T : IComparable
        {
            dynamic sum = 0;
            foreach (var item in array)
            {
                sum += item;
            }
            return sum;
        }

        public static T Product<T>(this IEnumerable<T> array)
           where T : IComparable
        {
            dynamic product = 1;
            foreach (var item in array)
            {
                product *= item;
            }
            return product;
        }

        public static T Min<T>(this IEnumerable<T> array)
           where T : IComparable
        {
            var arr = array.ToArray<T>();
            T min = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) <= 0)
                {
                    if ((dynamic)arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                else
                {
                    if ((dynamic)arr[i + 1] < min)
                    {
                        min = arr[i + 1];
                    }
                }
            }
            return min;
        }

        public static T Max<T>(this IEnumerable<T> array)
           where T : IComparable
        {
            var arr = array.ToArray<T>();
            T max = arr[0];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i].CompareTo(arr[i + 1]) >= 0)
                {
                    if ((dynamic)arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
                else
                {
                    if ((dynamic)arr[i + 1] > max)
                    {
                        max = arr[i + 1];
                    }
                }
            }
            return max;
        }

        public static T Average<T>(this IEnumerable<T> array)
           where T : struct, IComparable
        {
            dynamic average = 0;
            int count = array.ToArray<T>().Length;
            foreach (var item in array)
            {
                average += item;                
            }
            return average/count;
        }
    }
}
