using System;
namespace DSandAlgo_8.Homework
{
    public class Task_5
    {
        public static void Run()
        {
            int elements = 3;
            int k = 2;

            List<string> n /* possibilities */ = new List<string>() { "hi", "a", "b" };
            List<string> p /* permutations */ = new List<string>();

            Logic(n, elements, p, "");
            Print(p);
        }

        public static void Logic(List<string> n, int elementsLeft, List<string> p, string currentElement)
        {
            //Console.WriteLine("Step: " + currentElement);

            if (elementsLeft < 0)
            {
                return;
            }
            if (elementsLeft == 0)
            {
                p.Add(currentElement);
                return;
            }
            else
            {
                foreach (var item in n) // possibilities
                {
                    Logic(n, elementsLeft - 1, p, currentElement + item);
                }
            }
        }

        public static void Print(List<string> n)
        {
            Console.WriteLine("-----------Combinations---------");
            foreach (var element in n)
            {
                Console.Write(element + ", ");
            }

        }
    }
}

