using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HQPC_Controls_Conditionals_Loops
{
    public class SearchValue
    {
        static void Main()
        {
            int[] array = new int[1000];
            int expectedValue = 666;

            for (int i = 0; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        Console.WriteLine("Value Found");
                        break;
                    }
                }
            }
        }
    }
}