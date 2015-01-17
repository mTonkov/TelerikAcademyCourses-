using System;
using System.Text;
//using System.Collections.Generic;

namespace AsciiTable
{
    class AsciiTable
    {
        static void Main()
        {
            //Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console.

            char symbol;
            Console.OutputEncoding = Encoding.Unicode;
            for (int i = 0; i <= byte.MaxValue; i++)
            {
                symbol = (char)i;
                Console.WriteLine("{0} is the code of {1}", i, symbol);
                
            }
        }
    }
}
