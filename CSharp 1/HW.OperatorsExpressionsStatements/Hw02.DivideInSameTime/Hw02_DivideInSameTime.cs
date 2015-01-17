using System;


namespace Hw02_DivideInSameTime
{
    class Hw02_DivideInSameTime
    {
        static void Main()
        {
            /*Write a boolean expression that checks for given integer 
            if it can be divided (without remainder)
            by 7 and 5 in the same time.*/

            Console.WriteLine("Please insert an integer number!");
            int integer = int.Parse(Console.ReadLine());

            if (integer % 5 == 0 && integer % 7 == 0)
            {
                Console.WriteLine("Yes, the given integer can be divided by 5 and 7 in the same time!\n");
            }
            else
            { Console.WriteLine("Sorry, the given integer cannot be divided by 5 and 7 in the same time!\n"); 
            }
        }
    }
}
