using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TreeNodes
{
    public class TreeNode<T>
    {
        private List<TreeNode<T>> children;

        public TreeNode(T value)
            : this()
        {
            this.NodeValue = value;
        }

        public TreeNode()
        {
            this.Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> childNode)
        {
            if (childNode == null)
            {
                throw new NullReferenceException("Trying to add a child with null reference");
            }
            this.children.Add(childNode);
        }

        public List<TreeNode<T>> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public T NodeValue { get; set; }

        public bool HasParent { get; set; }

    }
}
