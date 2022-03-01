using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.TreeTest1
{
    internal class Menu
    {
        public static bool Run()
        {
            Console.WriteLine("My binary search tree\n");

            TreeTest1.Tree tree = new TreeTest1.Tree();

            tree.Insert(75);
            tree.Insert(57);
            tree.Insert(90);
            tree.Insert(32);
            tree.Insert(7);
            tree.Insert(44);
            tree.Insert(60);
            tree.Insert(86);
            tree.Insert(93);
            tree.Insert(99);
            tree.Insert(100);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose between 1 - 15 \n");
                Console.WriteLine("---------------------------------------------------\n");
                Console.WriteLine("1. In Order Traversal\n" +
                    "2. Pre Order Traversal \n" +
                    "3. Post Order Traversal\n" +
                    "4. Find\n" +
                    "5. Find recursively\n" +
                    "6. Delete a leaf node\n" +
                    "7. Delete a node with one child\n" +
                    "8. Delete a node with two child nodes\n" +
                    "9. Soft delete a node with one child\n" +
                    "10. Smallest node\n" +
                    "11. Largest node\n" +
                    "12. Number of leaf nodes\n" +
                    "13. Height of the tree\n" +
                    "14. Is the tree balanced\n" +
                    "15. EXIT");

                bool userInput = int.TryParse(Console.ReadLine(), out int input);

                switch (input)
                {
                    case 1:
                        Console.WriteLine("\nIn Order Traversal (Left -> Root -> Right");
                        tree.InOrderTraversal();
                        break;
                    case 2:
                        Console.WriteLine("\n Pre Order Traversal (Root -> Left -> Right");
                        tree.PreOrderTraversal();
                        break;
                    case 3:
                        Console.WriteLine("\n Post Order Traversal (Left -> Right -> Root");
                        tree.PostOrderTraversal();
                        break;
                    case 4:
                        Console.WriteLine("\n Find: 75");
                        var node = tree.Find(75);
                        Console.WriteLine(node);
                        break;
                    case 5:
                        Console.WriteLine("\n Find recursively: 99");
                        var nodeR = tree.FindRecursive(99);
                        Console.WriteLine(nodeR);
                        break;
                    case 6:
                        Console.WriteLine("\nDelete a Leaf Node (44");
                        tree.Remove(44);
                        break;
                    case 7:
                        Console.WriteLine("\nDelete a node with one child (93)");
                        tree.Remove(93);
                        break;
                    case 8:
                        Console.WriteLine("\nDelete a node with two child nodes (75)");
                        tree.Remove(75);
                        break;
                    case 9:
                        Console.WriteLine("\nSoft delete a node with one child (93)");
                        tree.SoftDelete(93);
                        break;
                    case 10:
                        Console.WriteLine("Get the smallest node");
                        Console.WriteLine(tree.Smallest());
                        break;
                    case 11:
                        Console.WriteLine("Get the largest node");
                        Console.WriteLine(tree.Largest());
                        break;
                    case 12:
                        Console.WriteLine("Get the number of leaf nodes");
                        Console.WriteLine(tree.NumberOfLeafNodes());
                        break;
                    case 13:
                        Console.WriteLine("Get the height of the tree");
                        Console.WriteLine(tree.Height());
                        break;
                    case 14:
                        Console.WriteLine("Is the tree balanced?");
                        Console.WriteLine(tree.IsBalanced());
                        break;
                    case 15:
                        return false;
                    default:
                        Console.WriteLine("Error! Please choose between 1 - 15");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
        #region Methods
        public static int getHeight(Node root)
        {
            if (root == null)
            {
                return 0;
            }
            return Math.Max(getHeight(root.LeftNode), getHeight(root.RightNode)) + 1;
        }

        public static bool isBalanced(Node root)
        {
            if (root == null)
            {
                return true;
            }
            int heightDiff = getHeight(root.LeftNode) - getHeight(root.RightNode);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            {
                return (isBalanced(root.LeftNode) && isBalanced(root.RightNode));
            }
        }
        #endregion
    }
}
