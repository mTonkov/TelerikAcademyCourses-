using System;


namespace PrintNullValues
{
    class PrintNullValues
    {
        static void Main()
        {
            //Create a program that assigns null values to an integer and to double variables. Try to print them on the console, try to add some values or the null literal to them and see the result.

            int? intNum = null;
            double? floatingNum = null;
            Console.Write("\"{0}\" - ", intNum);
            Console.WriteLine("\"{0}\"", intNum.GetValueOrDefault());

            Console.Write("\"{0}\" - ",floatingNum);
            Console.WriteLine("\"{0}\"", floatingNum.GetValueOrDefault());

            intNum = 5;
            floatingNum = 5.055;
            Console.Write("\"{0}\" - ", intNum);
            Console.WriteLine("\"{0}\"", intNum.GetValueOrDefault());

            Console.Write("\"{0}\" - ", floatingNum);
            Console.WriteLine("\"{0}\"", floatingNum.GetValueOrDefault());

        }
    }
}
