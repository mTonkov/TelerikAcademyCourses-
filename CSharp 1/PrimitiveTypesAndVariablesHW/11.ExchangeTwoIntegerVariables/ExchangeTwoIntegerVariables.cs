using System;


namespace ExchangeTwoIntegerVariables
{
    class ExchangeTwoIntegerVariables
    {
        static void Main()
        {
            int five = 5;
            int ten = 10;
            five = five << 1;
            ten = ten >> 1;

            Console.WriteLine("Five-> {0}",five);
            Console.WriteLine("Ten-> {0}",ten);
        }
    }
}
