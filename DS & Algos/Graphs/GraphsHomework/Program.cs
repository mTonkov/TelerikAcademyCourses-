using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsHomework
{
    class Program
    {
        static Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        static Dictionary<int, int> salaryPerEmployee = new Dictionary<int, int>();
        static HashSet<int> visited = new HashSet<int>();
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var hasManager = new bool[n];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    if (input[j] == 'Y')
                    {
                        hasManager[j] = true;
                        if (!graph.ContainsKey(i))
                        {
                            graph[i] = new List<int>();
                            salaryPerEmployee[i] = 0;
                        }
                        graph[i].Add(j);

                        if (!graph.ContainsKey(j))
                        {
                            graph[j] = new List<int>();
                            salaryPerEmployee[j] = 0;
                        }
                    }
                }
            }

            foreach (var node in graph)
            {
                if (!hasManager[node.Key])
                {
                    TraverseHierarchy(node.Key);
                }
            }

            int totalSum = 0;
            foreach (var salaryPair in salaryPerEmployee)
            {
                totalSum += salaryPair.Value;
            }
            if (n == 1)
            {
                totalSum = 1;
            }
            Console.WriteLine(totalSum);
        }


        private static void TraverseHierarchy(int startNode)
        {

            if (graph[startNode].Count == 0)
            {
                salaryPerEmployee[startNode] = 1;
                return;
            }
            else
            {
                foreach (var node in graph[startNode])
                {
                    if (salaryPerEmployee[node] == 0)
                    {
                        TraverseHierarchy(node);
                    }
                    salaryPerEmployee[startNode] += salaryPerEmployee[node];
                }
            }
        }
    }
}
