using System;


namespace ModifyInteger
{
    class ModifyInteger
    {
        static void Main()
        {
            /*We are given integer number n, value v (v=0 or 1) and a position p. 
             * Write a sequence of operators that modifies n to hold the value v 
             * at the position p from the binary representation of n.Example: 
             * n = 5 (00000101), p=3, v=1 -> 13 (00001101)
             * n = 5 (00000101), p=2, v=0 -> 1 (00000001)*/

            Console.WriteLine("Please insert your integer number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the position of the bit, which you want to check");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Please insert the the value you want to assign to the bit - '0' or '1'?");
            int v = int.Parse(Console.ReadLine());

            int mask = 1 << p;
            int result;

            if (v == 0)
            {
                mask = ~mask;
                result = mask & n;
            }
            else 
            {
                result = mask | n;
            }

            Console.WriteLine("n={0} ({1}), p={2}, v={3} -> {4} ({5})", n, Convert.ToString(n, 2).PadLeft(8, '0'), p, v, result, Convert.ToString(result, 2).PadLeft(8, '0'));
        }
    }
}
