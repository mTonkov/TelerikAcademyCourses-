using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ReadIntsAndReverse
{
    public class ReadIntsAndReverse
    { /*Write a program that reads N integers from the console and reverses them using a stack. 
       * Use the Stack<int> class*/
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the numbers one by one and type 'end' when you finish");

            var inputSequence = new Stack<int>();
            while (true)
            {
                string consoleInput = Console.ReadLine();
                if (consoleInput.ToLower() == "end")
                {
                    break;
                }

                int number = int.Parse(consoleInput);
                inputSequence.Push(number);
            }
            inputSequence.Reverse();
            Console.WriteLine("The reversed sequence is {0}", string.Join(", ", inputSequence));
        }
    }
}
