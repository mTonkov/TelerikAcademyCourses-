using System;
using System.Text;
using System.Threading;
using System.Globalization;
//Write a program that encodes and decodes a string using given encryption key (cipher). The key consists of a sequence of characters. 
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second 
//– with the second, etc. When the last key character is reached, the next is the first.

namespace EncodeDecode
{
    class Cipher
    {
        static void Main(string[] args)
        {
            
            string text = "Telerik Academy";
            StringBuilder codedMsg = new StringBuilder();
            string cipher = "AcDmy";

            //coding
            for (int i = 0; i < text.Length; i++)
            {   // the XOR operation returns int for the code of the XOR-ed codes of "text"[] and "cipher"[]
                codedMsg.Append((char)(text[i] ^ cipher[i % cipher.Length])); 
                //i % cipher.Length guarantees starting from the first element of the cipher, once the end is reached
            }
            Console.WriteLine("The coded messeage is: {0}", codedMsg);
            Console.WriteLine();
            Console.WriteLine();

            //decoding
            StringBuilder deCodedMsg = new StringBuilder();
            for (int i = 0; i < codedMsg.Length; i++)
            {
                deCodedMsg.Append((char)(codedMsg[i] ^ cipher[i % cipher.Length]));               
            }
            Console.WriteLine("The decoded messeage is: {0}", deCodedMsg);

        }
    }
}
