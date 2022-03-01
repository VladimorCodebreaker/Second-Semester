using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class Task2
    {
        public static void Run()
        {
            var numbers = Utility.ReadSequenceOfElements<int>();

            var elementsBackwards = new Stack<int>(numbers);

            PrintElementsBackwards(elementsBackwards);
        }

        public static void PrintElementsBackwards(Stack<int> elements)
        {
            while (elements.Count > 0)
            {
                Console.WriteLine(elements.Pop());
            }
        }
    }
}
