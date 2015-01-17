using System;

namespace ExchangeSomeBits
{
    class ProgExchangeSomeBitsram
    {
        static void Main()
        {
            //* Write a program that exchanges bits {p, p+1, …, p+k-1) with bits {q, q+1, …, q+k-1} of given 32-bit unsigned integer.

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
               * Imagine that the User wants to input a uint number, bigger than int.MaxValue, 
               * but in the same time Bitwise operations won't work with unsigned int.
               * To prevent any Exception issues with Overflow and Format, the program requires (uint),
               * but converts it to (long) - this saves the number without any loss of info and in the same time
               * enables Bitwise operations*/
            long number = (long)uintNum;

            byte p,q,k;
            while (true)
            {
                 Console.Write("Please enter the position of the first bit of the low-order sequence: p= ");
                 bool formatP = byte.TryParse(Console.ReadLine(), out p);

                 Console.Write("Please enter the position of the first bit of the high-order sequence: q= ");
                 bool formatQ = byte.TryParse(Console.ReadLine(), out q);

                 Console.Write("Please enter the lenght of P and Q sequences: k= ");
                 bool formatK = byte.TryParse(Console.ReadLine(), out k);

                 if (formatP && formatQ && formatK && p<q)
                    {
                        break;
                    }
                 else if (formatP && formatQ && formatK)
                 {
                     Console.WriteLine("The position of bit 'q' should be greater than the position of bit 'p' - The equation (q>p) must be satisfied");
                 }
                 else
                 {
                     Console.WriteLine("Positions of bits and legth of sequences cannot be negative numbers, text or symbols...");
                 }

            }

            long maskP, keepP;
            string keepBitsP = null;
            for (byte i = p; i < (p + k); i++)
            {                      //using this 'for' loop, I keep the value of bits in (p...p+k-1) sequence in <keepBitsP>
                maskP = 1 << i;
                keepP = (number & maskP) >> i;
                keepBitsP += Convert.ToString(keepP);
            }

            long maskQ, keepQ;
            string keepBitsQ = null;
            for (byte i = q; i < (q + k); i++)
            {                               // this loop keeps the value of bits in (q...q+k-1) sequence in <keepBitsQ>
                maskQ = 1 << i;
                keepQ = (number & maskQ) >> i;
                keepBitsQ += Convert.ToString(keepQ);
            }

            long clearBitP;
            for (byte i = p; i < (p + k); i++)
            {                               //this loop clears one by one the bits from the (p...p+k-1)sequence
                clearBitP = ~(1 << i);
                number = number & clearBitP; // each time <number> is stored, after every next bit in the sequence is cleared
            }

            long clearBitQ;
            for (byte i = q; i < (q + k); i++)
            {                               //this loop clears one by one the bits from the (q...q+k-1)sequence
                clearBitQ = ~(1 << i);
                number = number & clearBitQ; // each time <number> is stored, after every next bit in the sequence is cleared
            }

            byte bitP, bitQ;
            long exchange;

            for (byte i = 0; i < k; i++)
            {
                bitP = byte.Parse(keepBitsP[i].ToString()); //gets each of the stored p-bits (from the p...(p+k-1) sequence).
                exchange = bitP << (q + i);     // Bit 'p' goes to its new position (q+i) e.g. the first p-bit (keepBitsP[0]),
                number = exchange | number;     //  goes to position q+0, then is applied to the previously cleared q-bit

                bitQ = byte.Parse(keepBitsQ[i].ToString());
                exchange = bitQ << (p + i);
                number = exchange | number;
            }


            Console.WriteLine();
            Console.WriteLine("The number you entered is: \n {0} ( {1} ) ", uintNum, Convert.ToString(uintNum, 2).PadLeft(32, '0'));

            Console.WriteLine();
            Console.WriteLine("The new number, after exchanging bits is:\n {0} ( {1} )", number,
                                Convert.ToString(number, 2).PadLeft(32, '0'));


        }
    }
}
