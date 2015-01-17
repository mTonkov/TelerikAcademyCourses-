using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Dividing
{
    class Dividing
    {
        static void Main(string[] args)
        {
            int intTester = 1;
            long longTester = 1;
            float floatTester = 1.0f;
            double doubleTester = 1.0d;
            decimal decimalTester = 1.0m;

            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            for (int i = 0; i < 1000000; i++)
            {
                intTester = intTester / 1;
            }
            chrono.Stop();
            Console.Write("Dividing int numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longTester = longTester / 1;
            }
            chrono.Stop();
            Console.Write("Dividing long numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatTester = floatTester / 1;
            }
            chrono.Stop();
            Console.Write("Dividing float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleTester = doubleTester / 1;
            }
            chrono.Stop();
            Console.Write("Dividing double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalTester = decimalTester / 1;
            }
            chrono.Stop();
            Console.Write("Dividing decimal numbers:");
            Console.WriteLine(chrono.Elapsed);
        }
    }
}
