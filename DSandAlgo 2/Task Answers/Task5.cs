using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class Task5
    {
        public static void Run()
        {
            var numbers = Utility.ReadSequenceOfElements<decimal>().ToList();
            var positiveNumbers = ExtractPositiveNumbers(numbers);

            PrintResult(numbers, positiveNumbers);
        }

        public static IList<T> ExtractPositiveNumbers<T>(IList<T> collection) where T : IComparable
        {
            var positiveNumbers = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].CompareTo((T)Convert.ChangeType(0, typeof(T))) > 0)
                {
                    positiveNumbers.Add(collection[i]);
                }
            }

            return positiveNumbers;
        }

        public static void PrintResult(List<decimal> collection, IList<decimal> positiveNumbers)
        {
            Console.WriteLine("All numbers: " + String.Join(" ", collection));
            Console.WriteLine("Positive numbers: " + String.Join(" ", positiveNumbers));
        }
    }
}