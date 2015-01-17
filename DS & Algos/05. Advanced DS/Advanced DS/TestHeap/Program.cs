using _01.PriorityQueueWithHeap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestHeap
{
    class Program
    {
        static void Main(string[] args)
        {
            var heap = new Heap<int>();
            heap.Add(5);
            Console.WriteLine(string.Join(", ", heap.Print()));
            heap.Add(3);
            Console.WriteLine(string.Join(", ", heap.Print()));
            heap.Add(8);
            Console.WriteLine(string.Join(", ", heap.Print()));
            heap.Add(23);
            Console.WriteLine(string.Join(", ", heap.Print()));
            heap.Add(6);
            Console.WriteLine(string.Join(", ", heap.Print()));
            heap.Add(45);
            Console.WriteLine(string.Join(", ", heap.Print()));

            Console.WriteLine("Root: {0}", heap.Remove());
            Console.WriteLine(string.Join(", ", heap.Print()));
            Console.WriteLine("Root: {0}", heap.Remove());
            Console.WriteLine(string.Join(", ", heap.Print()));
            Console.WriteLine("Root: {0}", heap.Remove());
            Console.WriteLine(string.Join(", ", heap.Print()));
            Console.WriteLine("Root: {0}", heap.Remove());
            Console.WriteLine(string.Join(", ", heap.Print()));
            Console.WriteLine("Root: {0}", heap.Remove());
            Console.WriteLine(string.Join(", ", heap.Print()));
        }
    }
}
