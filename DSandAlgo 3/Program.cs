using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DS_and_Algo_3.TreeDemo;
using DS_and_Algo_3.Tree;
using DS_and_Algo_3.BinaryTreeExample;
using DS_and_Algo_3.TreeTest1;

namespace DS_and_Algo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Demo.Run();

            //TreeTraversalExercise.Run();

            #region BinaryTreeExample

            //Console.WriteLine("Binary Search Tree\n");

            //BinaryTree binaryTree = new BinaryTree();

            //binaryTree.Insert(75);
            //binaryTree.Insert(57);
            //binaryTree.Insert(90);
            //binaryTree.Insert(32);
            //binaryTree.Insert(7);
            //binaryTree.Insert(44);
            //binaryTree.Insert(60);
            //binaryTree.Insert(86);
            //binaryTree.Insert(93);
            //binaryTree.Insert(99);
            //binaryTree.Insert(100);

            //Console.WriteLine(binaryTree.Root.Data);

            //Console.Write("In Order Traversal (Left -> Root -> Right)\n");
            //binaryTree.InorderTraversal();
            //Console.WriteLine();
            //Console.Write("Pre Order Traversal (Root -> Left -> Right)\n");
            //binaryTree.PreorderTraversal();
            //Console.WriteLine();
            //Console.Write("Post Order Traversal (Left -> Right -> Root)\n");
            //binaryTree.PostorderTraversal();

            //Console.WriteLine("\nFind 99");
            //var node = binaryTree.Find(99);
            //Console.WriteLine(node.Data);
            //Console.WriteLine("Find Recursively 99");
            //var nodeR = binaryTree.FindRecursive(99);
            //Console.WriteLine(nodeR.Data);
            //Console.WriteLine("Delete a Leaf Node (44)");
            //binaryTree.Remove(44);
            //Console.WriteLine("Delete a Node with one child (93)");
            //binaryTree.Remove(93);
            //Console.WriteLine("SoftDelete a Node with one child nodes (75)");
            //binaryTree.Remove(75);
            //Console.WriteLine("SoftDelete a Node with one child (93)");
            //binaryTree.SoftDelete(93);

            //Console.WriteLine("Get Smallest node");
            //Console.WriteLine(binaryTree.Smallest());
            //Console.WriteLine("Get Largest node");
            //Console.WriteLine(binaryTree.Largest());
            //Console.WriteLine("Get the number of leaf nodes");
            //Console.WriteLine(binaryTree.NumberOfLeafNodes());
            //Console.WriteLine("Get the height of the tree");
            //Console.WriteLine(binaryTree.Height());

            //Check if the binary tree is balanced.A balanced tree occurs when the height of two subtrees of any node do not differ more than 1.
            //bool balanced = binaryTree.IsBalanced();

            #endregion

            Menu.Run();
        }
    }
}
