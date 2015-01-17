using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace SupermarketQueue
{
    class Program
    {
        static BigList<string> queue = new BigList<string>();
        static Bag<string> names = new Bag<string>();
        static StringBuilder result = new StringBuilder();
        static void Main(string[] args)
        {

            var line = Console.ReadLine();
            while (line.Trim() != "End")
            {
                var commandLine = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandLine[0];

                if (command == "Append")
                {
                    queue.Add(commandLine[1]);
                    names.Add(commandLine[1]);
                    result.AppendLine("OK");
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(commandLine[1]);
                    try
                    {
                        queue.Insert(index, commandLine[2]);
                        names.Add(commandLine[2]);
                        result.AppendLine("OK");
                    }
                    catch (Exception)
                    {
                        result.AppendLine("Error");
                    }
                }
                else if (command == "Find")
                {
                    result.AppendLine(names.NumberOfCopies(commandLine[1]).ToString());
                }
                else if (command == "Serve")
                {
                    var count = int.Parse(commandLine[1]);
                    try
                    {
                        result.AppendLine(string.Join(" ", queue.Range(0, count)));
                        names.RemoveMany(queue.Range(0, count));
                        queue.RemoveRange(0, count);
                    }
                    catch (Exception)
                    {
                        result.AppendLine("Error");
                    }
                }
                line = Console.ReadLine();
            }

            Console.WriteLine(result.ToString());
        }
    }
}
