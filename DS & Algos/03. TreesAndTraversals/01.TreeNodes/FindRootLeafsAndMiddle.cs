using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TreeNodes
{/*
  You are given a tree of N nodes represented as a set of N-1 pairs of nodes (parent node, child node), each in the range (0..N-1). 
  7        Write a program to read the tree and find:
2 4        a) the root node
3 2        b) all leaf nodes
5 0        c) all middle nodes
3 5        d) the longest path in the tree
5 6        e)* all paths in the tree with given sum S of their nodes
5 1        f)* all subtrees with given sum S of their nodes
*/
    public class FindRootLeafsAndMiddle
    {
        static void Main(string[] args)
        {
            var treeOfNodes = new Dictionary<int, TreeNode<int>>();
            BuildTree(treeOfNodes);

            //a
            var root = GetRoot(treeOfNodes);
            Console.WriteLine("a) The root is {0}", root.NodeValue);

            //b
            Console.WriteLine();
            Console.WriteLine("b) Middle nodes are: {0} ", string.Join(" ", GetMiddleNodes(treeOfNodes)));

            //c
            Console.WriteLine();
            Console.WriteLine("c) Leaves are: {0} ", string.Join(" ", GetLeaves(treeOfNodes)));

            int initialDepth = 0;
            int maxDepth = 0;
            TreeNode<int> nodeToBeDeepest = new TreeNode<int>();
            LongestPath(root, nodeToBeDeepest, initialDepth, ref maxDepth);

            Console.WriteLine();
            Console.WriteLine("Deepest node {0} was found on depth of {1}", nodeToBeDeepest.NodeValue, maxDepth);
        }


        public static void BuildTree(IDictionary<int, TreeNode<int>> tree)
        {
            int numberOfNodes = int.Parse(Console.ReadLine());
            var separators = new char[] { ' ' };
            for (int i = 0; i < numberOfNodes - 1; i++)
            {
                string nodeInput = Console.ReadLine();
                string[] currentNode = nodeInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                int nodeValue = int.Parse(currentNode[0]);
                int childNode = int.Parse(currentNode[1]);

                if (!tree.ContainsKey(nodeValue))
                {
                    tree[nodeValue] = new TreeNode<int>(nodeValue);
                }
                if (!tree.ContainsKey(childNode))
                {
                    tree[childNode] = new TreeNode<int>(childNode);
                }
                tree[childNode].HasParent = true;
                tree[nodeValue].AddChild(tree[childNode]);
            }

        }

        public static TreeNode<int> GetRoot(IDictionary<int, TreeNode<int>> tree)
        {
            TreeNode<int> root = new TreeNode<int>();
            foreach (var node in tree)
            {
                if (!node.Value.HasParent)
                {
                    root = node.Value;
                    break;
                }
            }

            return root;
        }

        private static IList<int> GetLeaves(IDictionary<int, TreeNode<int>> treeOfNodes)
        {
            var leaves = new List<int>();

            foreach (var node in treeOfNodes)
            {
                if (node.Value.Children.Count == 0)
                {
                    leaves.Add(node.Key);
                }
            }

            return leaves;
        }

        private static IList<int> GetMiddleNodes(IDictionary<int, TreeNode<int>> treeOfNodes)
        {
            var middleNodes = new List<int>();

            foreach (var node in treeOfNodes)
            {
                if (node.Value.HasParent && (node.Value.Children.Count > 0))
                {
                    middleNodes.Add(node.Key);
                }
            }

            return middleNodes;
        }

        public static void LongestPath(TreeNode<int> root, TreeNode<int> deepestNode, int depth, ref int maxDepth)
        {
            depth++;
            foreach (var child in root.Children)
            {
                if (depth > maxDepth)
                {
                    maxDepth = depth;
                    deepestNode = child;
                }
                LongestPath(child, deepestNode, depth, ref maxDepth);
            }
        }
    }
}
