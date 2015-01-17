using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.SmallerNumberOfCommands
{/** We are given numbers N and M and the following operations:
N = N+1
N = N+2
N = N*2
Write a program that finds the shortest sequence of operations from the list above that starts from N and finishes in M. Hint: use a queue.
Example: N = 5, M = 16
Sequence: 5 -> 7 -> 8 -> 16
*/
    public class SmallerNumberOfCommands
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            var sequence = new Stack<int>();
            sequence.Push(m);

            while (sequence.Peek() > n)
            {
                int current = sequence.Peek();

                if (current/2 > n)
                {
                    int operationValue = current / 2;
                    if (operationValue % 2 != 0)
                    {
                        operationValue -= 1;
                    }

                    sequence.Push(operationValue);
                }
                else if (current - 2 > n)
                {
                    sequence.Push(current - 2);
                }
                else 
                {
                    sequence.Push(current - 1);
                }
            }

            Console.WriteLine(string.Join(" -> ", sequence));
        }
    }
}
