using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.TreeTest1
{ // Binary search tree
    public class Node
    {
        private int data;
        public int Data
        {
            get { return this.data; }
        }

        private Node rightNode;
        public Node RightNode
        {
            get { return this.rightNode; }
            set { this.rightNode = value; }
        }

        private Node leftNode;
        public Node LeftNode
        {
            get { return this.leftNode; }
            set { this.leftNode = value; }
        }

        private bool isDeleted;
        public bool IsDeleted
        {
            get { return this.isDeleted; }
        }

        public Node(int value)
        {
            this.data = value;
        }

        public void Delete()
        {
            isDeleted = true;
        }

        public Node Find(int value)
        {
            Node currentNode = this;

            while (currentNode != null)
            {
                if (value == currentNode.data && IsDeleted == false)
                {
                    return currentNode;
                }
                else if (value > currentNode.data)
                {
                    currentNode = currentNode.rightNode;
                }
                else
                {
                    currentNode = currentNode.leftNode;
                }
            }

            return null;
        }

        public Node FindRecursive (int value)
        {
            if (value == data && IsDeleted == false)
            {
                return this;
            }
            else if (value < data && LeftNode != null)
            {
                return leftNode.FindRecursive(value);
            }
            else if (rightNode != null)
            {
                return rightNode.FindRecursive(value);
            }
            else
            {
                return null;
            }
        }

        public void Insert(int value)
        {
            if (value >= data)
            {
               if (rightNode == null)
                {
                    rightNode = new Node(value);
                }
               else
                {
                    rightNode.Insert(value);
                }
            }
            else
            {
                if (leftNode == null)
                {
                    leftNode = new Node(value);
                }
                else
                {
                    leftNode.Insert(value);
                }
            }
        }

        internal Nullable<int> SmallestValue()
        {
            if (leftNode == null)
            {
                return data;
            }
            else
            {
                return leftNode.SmallestValue();
            }
        }

        internal Nullable<int> LargestValue()
        {
            if (rightNode == null)
            {
                return data;
            }
            else
            {
                return rightNode.LargestValue();
            }
        }

        public void InOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.InOrderTraversal();
            }

            Console.Write(data + " ");

            if (rightNode != null)
            {
                rightNode.InOrderTraversal();
            }
        }

        public void PreOrderTraversal()
        {
            Console.Write(data + " ");

            if (leftNode != null)
            {
                leftNode.PreOrderTraversal();
            }

            if (rightNode != null)
            {
                rightNode.PreOrderTraversal();
            }
        }

        public void PostOrderTraversal()
        {
            if (leftNode != null)
            {
                leftNode.PostOrderTraversal();
            }

            if (rightNode != null)
            {
                rightNode.PostOrderTraversal();
            }

            Console.Write(data + " ");
        }

        public int Height()
        {
            if (this.leftNode == null && this.rightNode == null)
            {
                return 1;
            }

            int left = 0;
            int right = 0;

            if (this.leftNode != null)
            { left = this.leftNode.Height(); }
            if (this.rightNode != null)
            { right = this.rightNode.Height(); }

            if (left > right)
            {
                return left + 1;
            }
            else
            {
                return right + 1;
            }
        }

        public int NumberOfLeafNodes()
        {
            if (this.leftNode == null && this.rightNode == null)
            {
                return 1;
            }

            int leftLeaves = 0;
            int rightLeaves = 0;

            if (this.leftNode != null)
            {
                leftLeaves = leftNode.NumberOfLeafNodes();
            }
            if (this.rightNode != null)
            {
                rightLeaves = rightNode.NumberOfLeafNodes();
            }

            return leftLeaves + rightLeaves;
        }

        public bool IsBalanced()
        {
            int leftHeight = LeftNode != null ? LeftNode.Height() : 0;
            int rightHeight = RightNode != null ? RightNode.Height() : 0;

            int heightDifference = leftHeight - rightHeight;

            if (Math.Abs(heightDifference) > 1)
            {
                return false;
            }
            else
            {
                return ((LeftNode != null ? LeftNode.IsBalanced() : true) && (RightNode != null ? RightNode.IsBalanced() : true));
            }
        }
    }
}
