using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.BinaryTreeExample
{
    public class BinaryTree
    {
        private TreeNode root;
        public TreeNode Root
        {
            get { return this.root; }
        }

        // O(Log n)
        public TreeNode Find(int data)
        {
            if (root != null)
            {
                // call node method Find
                return root.Find(data);
            }
            else
            {
                return null;
            }
        }

        // O(Log n)
        public TreeNode FindRecursive(int data)
        {
            if (root != null)
            {
                return root.FindRecursive(data);
            }
            else
            {
                return null;
            }
        }

        // O(Log n)
        public void Insert(int data)
        {
            if (root != null)
            {
                root.Insert(data);
            }
            else
            {
                root = new TreeNode(data);
            }
        }

        public void Remove(int data)
        {
            TreeNode current = root;
            TreeNode parent = root;
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
                TreeNode successor = GetSuccessor(current);

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

        private TreeNode GetSuccessor(TreeNode node)
        {
            TreeNode parentofSuccessor = node;
            TreeNode successor = node;
            TreeNode current = node.RightNode;

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

        public void SoftDelete(int data)
        {
            TreeNode toDelete = Find(data);
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

        public void InorderTraversal()
        {
            if (root != null)
            {
                root.InOrderTraversal();
            }
        }

        public void PreorderTraversal()
        {
            if (root != null)
            {
                root.PreOrderTraversal();
            }
        }

        public void PostorderTraversal()
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

            return root.NumberOfLeafNodes();
        }

        public int Height()
        {
            if (root == null)
            {
                return 0;
            }

            return root.Height();
        }

        public bool IsBalanced()
        {
            if (root == null)
            {
                return true;
            }

            return root.IsBalanced();
        }
    }
}
