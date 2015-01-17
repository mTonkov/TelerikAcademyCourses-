using System;


namespace ExchangeBits
{
    class ExchangeBits
    {
        static void Main( )
        {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

            Console.WriteLine("Please enter an unsigned integer number");
            uint uintNum;
            while (true)
            {
                if (uint.TryParse(Console.ReadLine(), out uintNum))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid unsigned integer number");
                }
            } /*The task requires an input of type (uint). Bitwise operations turn some
               * numbers into negative, which requires (int). 
               * Imagine that the User wants to input a (uint) number, bigger than int.MaxValue, 
               * but in the same time, Bitwise operations won't work with (uint).
               * To solve this problen and prevent any Exception issues with Overflow and Format, 
               * because the task requires (uint) and the program needs (int),
               * I decided to convert the number to (long) - this saves the number without any loss 
               * of info and in the same time enables Bitwise operations*/

            long num = (long)uintNum;
                  // '7' is 0111
            long keepBits345 = 7 << 3;              //these operations keep bits 3,4,5 
            keepBits345 = (num & keepBits345) >> 3; //and put them in positions 0,1,2 of <keepBits345>

            long keepBits242526 = 7 << 24;              //these operations keep bits 24,25,26 the same way as 3,4,5
            keepBits242526 = (num & keepBits242526) >> 24;  //and put them in positions 0,1,2 of <keepBits242526>

            long mask = ~(7 << 3);  
                  //~(0111 << 3) = ~(0011 1000) = 11000111 
            num = mask & num; // this clears bits 3,4,5, where later 
                              // the values kept in <keepBits242526> will be transfered

            mask = ~(7 << 24);//here we repeat the previous procedure
            num = mask & num; //Now <num> is ready for the new values of the cleared bits (the exchange of the bits)
                              
            keepBits345 = keepBits345 << 24; //we move the kept bits 3,4,5 to their new positions in <num> (bits 24, 25, 26)
            keepBits242526 = keepBits242526 << 3; // preparing bits 24,25,26 for their new positions - 3,4,5
          
            long newNum = keepBits345 | num; //bits 24,25,26 are replaced with the initial bits 3,4,5
             newNum = keepBits242526 | newNum;//bits 3,4,5 are replaced with the initial bits 24,25,26

            Console.WriteLine();
            Console.WriteLine("The number you entered is: \n {0} ( {1} ) ", uintNum, Convert.ToString(uintNum, 2).PadLeft(32, '0'));
            
            Console.WriteLine();
            Console.WriteLine("The new number, after exchanging bits 3,4,5 and bits 24,25,26 is:\n {0} ( {1} )", newNum,
                                Convert.ToString(newNum, 2).PadLeft(32, '0'));

        }
    }
}
