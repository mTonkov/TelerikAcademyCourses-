using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.GetSequenceOf50
{/*We are given the following sequence:
S1 = N;
S2 = S1 + 1;
S3 = 2*S1 + 1;
S4 = S1 + 2;
S5 = S2 + 1;
S6 = 2*S2 + 1;
S7 = S2 + 2;
...
Using the Queue<T> class write a program to print its first 50 members for given N.
Example: N=2  2, 3, 5, 4, 4, 7, 5, 6, 11, 7, 5, 9, 6, ...
*/
    public class GetSequenceOf50
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert a single number:");

            int number = int.Parse(Console.ReadLine());

            var allNumbers = new List<int>();
            var queue = new Queue<int>();
            queue.Enqueue(number);

            while (allNumbers.Count < 50)
            {
                int dequeuedNumber = queue.Dequeue();
                allNumbers.Add(dequeuedNumber);
                queue.Enqueue(dequeuedNumber + 1);
                queue.Enqueue(2*dequeuedNumber + 1);
                queue.Enqueue(dequeuedNumber + 2);
            }

            Console.WriteLine("The sequence is:");
            Console.WriteLine(string.Join(", ", allNumbers));
        }
    }
}
