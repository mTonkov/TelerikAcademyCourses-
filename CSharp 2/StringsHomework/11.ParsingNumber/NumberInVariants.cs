using System;
//Write a program that reads a number and prints it as a decimal number, hexadecimal number, percentage and in scientific notation. 
//Format the output aligned right in 15 symbols.


namespace ParsingNumber
{
    class NumberInVariants
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("{0,15}\n{0,15:X}\n{0,15:P1}\n{0,15:E}\n", number);
        }
    }
}
