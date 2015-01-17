using System;


namespace Hw01_OddOrEven
{
    class Hw01_OddOrEven
    {
        static void Main()
        {
            //Write an expression that checks if given integer is odd or even.

             bool repeat = true;
            while (repeat == true)
            {
                Console.WriteLine("Please insert an integer number!");
                int integer = int.Parse(Console.ReadLine());

                if (integer % 2 == 0)
                {
                    Console.WriteLine("The entered number is Even \n");
                }
                else
                {
                    Console.WriteLine("The entered number is Odd \n");
                }
                
                Console.WriteLine("Would you like to try again? \n Y/N?");

                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y") //if the answer is not "Y" or "y", the program will stop
                {
                    repeat = true;
                }
                else
                {
                    repeat = !repeat;
                }
            }
        }
    }
}
