using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class Task7
    {
        /* 7. Write a program that finds in a given array of integers
         * (all belonging to the range [0..1000]) how many times each
         * of them occures.
         * 
         * Example: array = {3, 4, 4, 3, 4, 4, 3, 2}
         * 2 -> 2 times
         * 3 -> 3 times
         * 4 -> 4 times
         */

        public static void Run()
        {
            var elements = Utility.ReadSequenceOfElements<int>().ToList();
            var occurences = FindElementsOccurences(elements);

            Print(occurences);
        }

        public static IDictionary<T, int> FindElementsOccurences<T>(IList<T> collection)
        {
            var dictionary = new Dictionary<T, int>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (dictionary.ContainsKey(collection[i]))
                {
                    dictionary[collection[i]]++;
                }
                else
                {
                    dictionary[collection[i]] = 1;
                }
            }

            return dictionary;
        }

        public static void Print(IDictionary<int, int> occurences)
        {
            foreach (var element in occurences)
            {
                Console.WriteLine($"{element.Key} -> {element.Value} times");
            }
        }
    }
}
