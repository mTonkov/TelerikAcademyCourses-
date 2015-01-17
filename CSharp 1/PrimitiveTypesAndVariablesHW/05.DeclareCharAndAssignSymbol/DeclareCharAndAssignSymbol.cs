using System;


namespace DeclareCharAndAssignSymbol
{
    class DeclareCharAndAssignSymbol
    {
        static void Main()
        {
            //Declare a character variable and assign it with the symbol that has Unicode code 72. Hint: first use the Windows Calculator to find the hexadecimal representation of 72
            
            //int unicodeSymbol = 0x0072;
            //Console.WriteLine(unicodeSymbol);
            //char character = (char)unicodeSymbol;
            //Console.WriteLine(character);
            int unicodeNum = 72;
            char character = (char)unicodeNum;
            Console.WriteLine(character);
            //char uni = (char)'\u0048';
            //Console.WriteLine(uni);


        }
    }
}
