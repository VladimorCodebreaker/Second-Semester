using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel; // ?

namespace DS_and_Algo_3.Tree
{
    internal class Tree<T>
    {
        private readonly IDictionary<T, Node<T>> nodes = new Dictionary<T, Node<T>>();

        public Node<T> ParentNode
        {
            get
            {
                return this.nodes.Values.First(n => n.Parent == null);
            }
        }

        public IReadOnlyCollection<Node<T>> Nodes
        {
            get
            {
                return new ReadOnlyCollection<Node<T>>(this.nodes.Values.ToList());
            }
        }

        public IReadOnlyCollection<Node<T>> MiddleNodes
        {
            get
            {
                var middleNodes = this.nodes.Values.Where(n => n.Children.Count != 0 && n.Parent != null).ToList();
                return new ReadOnlyCollection<Node<T>>(middleNodes);
            }
        }

        public IReadOnlyCollection<Node<T>> LeafNodes
        {
            get
            {
                var leafNodes = this.nodes.Values.Where(n => n.Children.Count == 0).ToList();
                return new ReadOnlyCollection<Node<T>>(leafNodes);
            }
        }

        public void ConnectNodes(T parentNodeValue, T childNodeValue)
        {
            var parentNode = this.TryGetNode(parentNodeValue);
            var childNode = this.TryGetNode(childNodeValue);
            parentNode.Children.Add(childNode); // ?
            childNode.Parent = parentNode;
        }

        private Node<T> TryGetNode(T nodeValue)
        {
            if (!this.nodes.ContainsKey(nodeValue))
            {
                var node = new Node<T>(nodeValue);
                this.nodes[nodeValue] = node;
                return node;
            }

            return this.nodes[nodeValue];
        }
    }
}
