using System;
using System.Text;

namespace IsoscelesTriangleWithCopyRightSymbol
{
    class IsoscelesTriangleWithCopyRightSymbol
    {
        static void Main()
        {
            //Write a program that prints an isosceles triangle of 9 copyright symbols ©. Use Windows Character Map to find the Unicode code of the © symbol. Note: the © symbol may be displayed incorrectly.

            char copyRight = '\u00A9';
            Console.OutputEncoding = Encoding.Unicode;
            int size = 3;
            for (int i = 0; i < size; i++) //The "for" loop creates the number of floors or levels specified by the variable "size"
            {
                Console.WriteLine(new string(' ', size - i) + new string(copyRight, 2 * i + 1));
            } //prints "space" until (size-i), where it prints "copyright" (2*i+1) times


//The code below also creates an isosceles triangle but it makes it hollow, not solid as the one printed with the code above.

            //char copyRight = '\u00A9';
            //Console.OutputEncoding = Encoding.Unicode;
            //int size = 3;
            //for (int i = 0; i < size-1; i++) // In this loop, "i" is the number of rows and will reach (size-1), because the last row will be printed solid as a basis of the triangle 
            //    {
            //        for (int j = 1; j <= size+i; j++) // "j" is number of positions on a single row and reaches (size+i) in order to print the symbol on both sides of the triangle. (size+i) is raise for each new row "i"
            //        {
            //            if (j == size - i || j == size + i) //this ensures that symbol will be put symmetrically on both sides of the triangle 
            //            {
            //                Console.Write(copyRight);
            //            }
            //            else 
            //            {
            //                Console.Write(" ");
            //            }
            //        }

            //        Console.WriteLine();
            //    }

            //Console.WriteLine(new string(copyRight, 2 * size-1));

        }
    }
}
