using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class Task6
    {
        /* 6. Write a program that removes from a given sequence 
         * all numbers that occur odd number of times.
         * Example: {4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2} -> {5, 3, 3, 5}
         */
        public static void Run()
        {
            var numbers = Utility.ReadSequenceOfElements<int>().ToList();

            var extractedElements = FindElements(numbers, oddNumberOfTimes: false);

            Print(numbers, extractedElements);
        }

        public static ISet<T> FindElements<T>(IList<T> collection, bool oddNumberOfTimes)
        {
            var oddOccurences = new HashSet<T>();
            var evenOccurences = new HashSet<T>();

            foreach (var element in collection)
            {
                if (oddOccurences.Add(element))
                {
                    evenOccurences.Remove(element);
                }
                else
                {
                    oddOccurences.Remove(element);
                    evenOccurences.Add(element);
                }
            }

            return oddNumberOfTimes ? oddOccurences : evenOccurences;
        }

        public static void Print(IList<int> collection, ISet<int> evenNumberOfTimes)
        {
            var originalOrderOfElements = collection.Where(e => evenNumberOfTimes.Contains(e));
            Console.WriteLine("Result (even order): " + String.Join(" ", originalOrderOfElements));
        }
    }
}
