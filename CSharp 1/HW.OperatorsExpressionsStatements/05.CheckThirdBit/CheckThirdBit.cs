using System;

namespace CheckThirdBit
{
    class CheckThirdBit
    {
        static void Main()
        {
            //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.

            Console.WriteLine("Please input an integer number:");
            int input = int.Parse(Console.ReadLine());

            int mask = 8; //bit 3, counting from 0 is the 4th bit (1000), which is the number 8
            bool check = (input & mask)==0; 
            /*As 8 has '1' only on bit 3 and 0 on all other bits, 
             * if the input has '1' on bit 3, the result of will always be the number 8. 
             * If the input has '0' on the bit 3, the resul will always be the number 0.*/
            Console.WriteLine("The bit 3 of the input is 0: -> " + check);

        }
    }
}
