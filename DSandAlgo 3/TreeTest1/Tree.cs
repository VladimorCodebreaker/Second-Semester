using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.TreeTest1
{
    public class Tree
    {
        private Node root;
        public Node Root
        {
            get { return this.root; }
        }

        public Node Find(int value)
        {
            if (root != null)
            {
                return root.Find(value);
            }
            else
            {
                return null;
            }
        }

        public Node FindRecursive(int value)
        {
            if (root != null)
            {
                return root.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            if (root != null)
            {
                root.Insert(value);
            }
            else
            {
                root = new Node(value);
            }
        }

        public void Remove(int data)
        {
            Node current = root;
            Node parent = root;
            bool isLeftChild = false;

            if (current == null)
            {
                return;
            }

            while (current != null && current.Data != data)
            {
                parent = current;

                if (data < current.Data)
                {
                    current = current.LeftNode;
                    isLeftChild = true;
                }
                else
                {
                    current = current.RightNode;
                    isLeftChild = false;
                }
            }

            if (current == null)
            {
                return;
            }

            if (current.RightNode == null && current.LeftNode == null)
            {
                if (current == root)
                {
                    root = null;
                }
                else
                {
                    if (isLeftChild)
                    {
                        parent.LeftNode = null;
                    }
                    else
                    {
                        parent.RightNode = null;
                    }
                }
            }

            else if (current.RightNode == null)
            {
                if (current == root)
                {
                    root = current.LeftNode;
                }
                else
                {
                    if (isLeftChild)
                    {
                        parent.LeftNode = current.LeftNode;
                    }
                    else
                    {
                        parent.RightNode = current.LeftNode;
                    }
                }
            }
            else if (current.LeftNode == null)
            {
                if (current == root)
                {
                    root = current.RightNode;
                }
                else
                {
                    if (isLeftChild)
                    {
                        parent.LeftNode = current.RightNode;
                    }
                    else
                    {
                        parent.RightNode = current.RightNode;
                    }
                }
            }
            else
            {
                Node successor = GetSuccessor(current);

                if (current == root)
                {
                    root = successor;
                }
                else if (isLeftChild)
                {
                    parent.LeftNode = successor;
                }
                else
                {
                    parent.RightNode = successor;
                }
            }
        }

        private Node GetSuccessor(Node node)
        {
            Node parentofSuccessor = node;
            Node successor = node;
            Node current = node.RightNode;

            while (current != null)
            {
                parentofSuccessor = successor;
                successor = current;
                current = current.LeftNode;
            }
            if (successor != node.RightNode)
            {
                parentofSuccessor.LeftNode = successor.RightNode;
                successor.RightNode = node.RightNode;
            }

            successor.LeftNode = node.LeftNode;

            return successor;
        }

        public void SoftDelete(int value)
        {
            Node toDelete = Find(value);
            if (toDelete != null)
            {
                toDelete.Delete();
            }
        }

        public Nullable<int> Smallest()
        {
            if (root != null)
            {
                return root.SmallestValue();
            }
            else
            {
                return null;
            }
        }

        public Nullable<int> Largest()
        {
            if (root != null)
            {
                return root.LargestValue();
            }
            else
            {
                return null;
            }
        }

        public void InOrderTraversal()
        {
            if (root != null)
            {
                root.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()
        {
            if (root != null)
            {
                root.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            if (root != null)
            {
                root.PostOrderTraversal();
            }
        }

        public int NumberOfLeafNodes()
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return root.NumberOfLeafNodes();
            }
        }

        public int Height()
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                return root.Height();
            }
        }

        public bool IsBalanced()
        {
            if (root == null)
            {
                return true;
            }
            else
            {
                return root.IsBalanced();
            }
        }

        //There are many self balancing trees
        //Some to look at are
        //Red Black Trees
        //AVL Trees
    }
}
