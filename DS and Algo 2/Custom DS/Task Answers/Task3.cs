using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class Task3
    {
        public static void Run()
        {
            var elements = Utility.ReadSequenceOfElements<int>();

            List<int> sortedCollection = elements.OrderBy(a => a).ToList();
            Console.WriteLine("Sorted List: " + string.Join(" ", sortedCollection));

            SortedSet<int> sortedSet = new SortedSet<int>(elements);
            Console.WriteLine("Sorted set: " + String.Join(" ", sortedSet));

        }
    }
}
