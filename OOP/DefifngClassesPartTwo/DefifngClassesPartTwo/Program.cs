using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPartTwo
{
    class Program
    {
        
        static void Main(string[] args)
        {
            GenericList<int> nums = new GenericList<int>(2);
            nums.Add(5);
            nums.Add(22);
            //nums.InsertAt(2, 55);
            //nums.RemoveAt(1);
            //int number = nums.Access(6);
            //int index = nums.IndexOf(55);
            //nums.Clear();

            int min = nums.Min<int>();
            int max = nums.Max<int>();

            /////////////////////////////// task 11
            Type classType = typeof(SampleClass);
            var allAttrs = classType.GetCustomAttributes(typeof(VersionAttribute), true);

            foreach (VersionAttribute attribute in allAttrs)
            {
                Console.WriteLine("Version is {0}.{1}", attribute.major, attribute.minor);
            }
        }
    }
}
