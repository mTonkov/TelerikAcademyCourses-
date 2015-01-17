using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ExtractOddOccurencies
{/*02. Write a program that extracts from a given sequence of strings all elements that present in it odd number of times. Example:
{C#, SQL, PHP, PHP, SQL, SQL }  {C#, SQL}
*/
    class ExtractOddOccurencies
    {
        public static void Main()
        {
            string[] array = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };

            var counter = new Dictionary<string, int>();

            for (int i = 0; i < array.Length; i++)
            {
                string currentItem = array[i];
                if (!counter.ContainsKey(currentItem))
                {
                    counter[currentItem] = 0;
                }

                counter[currentItem]++;
            }

            foreach (var pair in counter)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write("{0} ", pair.Key);
                }
            }
            Console.WriteLine();
        }
    }
}
