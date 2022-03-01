using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.TreeDemo
{
    internal class TreeNode<T>
    {
        private T value;
        private List<TreeNode<T>> children;
        private bool hasParent;

        public TreeNode(T value)
        {
            this.value = value;
            this.children = new List<TreeNode<T>>();
        }
        
        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public void AddChild(TreeNode<T> child)
        {
            child.hasParent = true;
            this.children.Add(child);
        }

        public TreeNode<T> GetChild (int index)
        {
            return this.children[index];
        }
    }
}
