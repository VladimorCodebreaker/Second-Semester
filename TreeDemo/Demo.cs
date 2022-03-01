using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_3.TreeDemo
{
    internal class Demo
    {
        public static void Run()
        {
            Tree<int> tree = new Tree<int>(7, new Tree<int>(19),
                new Tree<int>(1), new Tree<int>(12), new Tree<int>(31),
                new Tree<int>(21), new Tree<int>(14), new Tree<int>(23),
                new Tree<int>(6));

            var rootValue = tree.Root.Value; // 7 -> root value
            Console.WriteLine(rootValue);
            Console.WriteLine();
            

            Tree<string> tree1 = new Tree<string>("root");
            tree1.Root.AddChild(new TreeNode<string>("second"));

            var node3 = new TreeNode<string>("third");
            tree1.Root.AddChild(node3);

        }
    }
}
