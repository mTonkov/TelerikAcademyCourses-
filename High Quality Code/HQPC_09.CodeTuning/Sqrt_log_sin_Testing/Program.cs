using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sqrt_log_sin_Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            float floatTester = 0.0f;
            double doubleTester = 0.0d;
            decimal decimalTester = 0.0m;

            Stopwatch chrono = new Stopwatch();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatTester = (float)Math.Sqrt(i);
            }
            chrono.Stop();
            Console.Write("Sqrt float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleTester = Math.Sqrt(i);
            }
            chrono.Stop();
            Console.Write("Sqrt double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalTester = (decimal)Math.Sqrt(i);
            }
            chrono.Stop();
            Console.Write("Sqrt decimal numbers:");
            Console.WriteLine(chrono.Elapsed);
            Console.WriteLine(new string('=', 40));
            chrono.Reset();
            chrono.Start();

            for (double i = 1; i < 1000; i+=0.05d)
            {
                floatTester = (float)Math.Log(i);
            }
            chrono.Stop();
            Console.Write("Log() float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (double i = 1; i < 1000; i += 0.05d)
            {
                doubleTester = Math.Log(i);
            }
            chrono.Stop();
            Console.Write("Log() double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (double i = 1; i < 1000; i += 0.05d)
            {
                decimalTester = (decimal)Math.Log(i);
            }
            chrono.Stop();
            Console.Write("Log() decimal numbers:");
            Console.WriteLine(chrono.Elapsed);
            Console.WriteLine(new string('=', 40));

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                floatTester = (float)Math.Sin(i);
            }
            chrono.Stop();
            Console.Write("Sin float numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                doubleTester = Math.Sin(i);
            }
            chrono.Stop();
            Console.Write("Sin double numbers:");
            Console.WriteLine(chrono.Elapsed);

            chrono.Reset();
            chrono.Start();

            for (int i = 0; i < 1000000; i++)
            {
                decimalTester = (decimal)Math.Sin(i);
            }
            chrono.Stop();
            Console.Write("Sin decimal numbers:");
            Console.WriteLine(chrono.Elapsed);


        }
    }
}
