using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtensionMethodsDelegatesLambdaLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> p = new int[] { 1, 2, -3, 0, -1 };
            //  dynamic res = p.Summm();
            //dynamic minRes = p.Min<int>();
            //Console.WriteLine(minRes);
            dynamic maxRes = p.Max<int>();
            Console.WriteLine(maxRes);

        }
    }
}
