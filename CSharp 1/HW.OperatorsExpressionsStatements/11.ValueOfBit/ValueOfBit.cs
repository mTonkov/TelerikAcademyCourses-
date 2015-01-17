using System;


namespace ValueOfBit
{
    class ValueOfBit
    {
        static void Main( )
        {
            //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2 -> value=1.

            Console.WriteLine("Please insert your integer number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the position of the bit, which value you want to check");
            int b = int.Parse(Console.ReadLine());

            int mask = 1 << b;
            int result;

            result = mask & i;
            result = result >> b;

            Console.WriteLine("The bit on position {0} of number {1}, has value -> {2}", b, i, result);

        }
    }
}
