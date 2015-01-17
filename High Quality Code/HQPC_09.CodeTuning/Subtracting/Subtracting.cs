using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtracting
{
    class Subtracting
    {
        static void Main(string[] args)
        {
            int intTester = 1000000;
            long longTester = 1000000;
            float floatTester = 1000000.0f;
            double doubleTester = 1000000.0d;
            decimal decimalTester = 1000000.0m;

            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            for (int i = 0; i < 1000000; i++)
            {
                intTester = intTester - 1;
            }
            chrono.Stop();
            Console.Write("Subtracting int numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longTester = longTester - 1;
            }
            chrono.Stop();
            Console.Write("Subtracting long numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatTester = floatTester - 1;
            }
            chrono.Stop();
            Console.Write("Subtracting float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleTester = doubleTester - 1;
            }
            chrono.Stop();
            Console.Write("Subtracting double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalTester = decimalTester - 1;
            }
            chrono.Stop();
            Console.Write("Subtracting decimal numbers:");
            Console.WriteLine(chrono.Elapsed);
        }
    }
}
