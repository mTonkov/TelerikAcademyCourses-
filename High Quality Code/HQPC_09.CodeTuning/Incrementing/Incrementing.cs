using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Incrementing
{
    class Incrementing
    {
        static void Main(string[] args)
        {
            int intTester = 0;
            long longTester = 0;
            float floatTester = 0.0f;
            double doubleTester = 0.0d;
            decimal decimalTester = 0.0m;

            Stopwatch chrono = new Stopwatch();
            chrono.Start();
            for (int i = 0; i < 1000000; i++)
            {
                intTester ++;
            }
            chrono.Stop();
            Console.Write("Subtracting int numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longTester ++;
            }
            chrono.Stop();
            Console.Write("Subtracting long numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatTester ++;
            }
            chrono.Stop();
            Console.Write("Subtracting float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleTester ++;
            }
            chrono.Stop();
            Console.Write("Subtracting double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalTester ++;
            }
            chrono.Stop();
            Console.Write("Subtracting decimal numbers:");
            Console.WriteLine(chrono.Elapsed);
        }
    }
}
