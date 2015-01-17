using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HQPC_CodeTuning
{
    class Adding
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
                intTester = intTester + 1;
            }
            chrono.Stop();
            Console.Write("adding int numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                longTester = longTester + 1;
            }
            chrono.Stop();
            Console.Write("adding long numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatTester = floatTester + 1;
            }
            chrono.Stop();
            Console.Write("adding float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleTester = doubleTester + 1;
            }
            chrono.Stop();
            Console.Write("adding double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalTester = decimalTester + 1;
            }
            chrono.Stop();
            Console.Write("adding decimal numbers:");
            Console.WriteLine(chrono.Elapsed);
        }
    }
}
