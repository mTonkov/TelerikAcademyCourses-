using System;


namespace IsBitOnPositionOne
{
    class IsBitOnPositionOne

    {
        static void Main( )
        { 
            //Write a boolean expression that returns if the bit at position p (counting from 0) 
            //in a given integer number v has value of 1. Example: v=5; p=1 -> false

            Console.WriteLine("Please insert your integer number");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the position of the bit, which you want to check");
            int p = int.Parse(Console.ReadLine());

            int mask = 1 << p;

            mask = mask & v;
            mask = mask >> p;
            bool result = mask == 1;

            Console.WriteLine("The bit on position {0} of the numer {1} which you just entered is \"1\" -> {2}", p, v, result);
        }
    }
}
