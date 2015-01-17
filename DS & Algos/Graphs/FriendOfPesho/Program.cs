using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOfPesho
{
    public class Edge : IComparable<Edge>
    {
        public Edge(int startNode, int endNode, int weight)
        {
            this.StartNode = startNode;
            this.EndNode = endNode;
            this.Weight = weight;
        }

        public int StartNode { get; set; }

        public int EndNode { get; set; }

        public int Weight { get; set; }

        public int CompareTo(Edge other)
        {
            int weightCompared = this.Weight.CompareTo(other.Weight);

            if (weightCompared == 0)
            {
                return this.StartNode.CompareTo(other.StartNode);
            }
            return weightCompared;
        }

        public override string ToString()
        {
            return string.Format("({0} {1}) -> {2}", this.StartNode, this.EndNode, this.Weight);
        }
    }

    class Program
    {
        static int[] hospitals;
        public static void Main()
        {
            var initialParams = Console.ReadLine()
                .Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();
            int numberOfNodes = initialParams[0];
            int numberOfEdges = initialParams[1];
            int numberOfHospitals = initialParams[2];

            hospitals = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

            var edges = new List<Edge>();
            for (int i = 0; i < numberOfEdges; i++)
            {
                var edgeData = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                edges.Add(new Edge(edgeData[0], edgeData[1], edgeData[2]));
            }

            int minDistance = int.MaxValue;
            foreach (var hospital in hospitals)
            {
                var priority = new SortedSet<Edge>();
                var used = new bool[numberOfNodes + 1];
                var mpdNodes = new List<Edge>();

                foreach (Edge edge in edges)
                {
                    if (edge.StartNode == hospital)
                    {
                        priority.Add(edge);
                    }
                }

                foreach (var hospitalToIgnore in hospitals)
                {
                    used[hospitalToIgnore] = true;
                }
                int currentDistance = 0;
                FindMinimumSpanningTree(used, priority, mpdNodes, edges, ref currentDistance);

                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }
            }

            Console.WriteLine(minDistance);
        }

        private static void FindMinimumSpanningTree(bool[] used, SortedSet<Edge> priority, List<Edge> mpdEdges, List<Edge> edges, ref int currentDistance)
        {
            while (priority.Count > 0)
            {
                Edge edge = priority.Min;
                priority.Remove(edge);

                if (!used[edge.EndNode])
                {
                    used[edge.EndNode] = true; // we "visit" this node
                    mpdEdges.Add(edge);
                    currentDistance += edge.Weight;
                    edge.Weight = currentDistance;
                    AddEdges(edge, edges, mpdEdges, priority, used);
                }
            }
        }

        private static void AddEdges(Edge edge, List<Edge> edges, List<Edge> mpd, SortedSet<Edge> priority, bool[] used)
        {
            for (int i = 0; i < edges.Count; i++)
            {
                if (!mpd.Contains(edges[i]))
                {
                    if (edge.EndNode == edges[i].StartNode && !used[edges[i].EndNode])
                    {
                        priority.Add(edges[i]);
                    }
                }
            }
        }
    }
}
