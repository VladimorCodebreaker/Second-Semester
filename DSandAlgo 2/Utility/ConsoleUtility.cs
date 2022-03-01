using System;
using System.Collections.Generic;

namespace Utility
{
    public class ConsoleUtility
    {
        public static IEnumerable<T> ReadSequenceOfElements<T>() where T : IComparable
        {
            Console.WriteLine("Please enter a sequence of elements.");
            Console.WriteLine($"Elements should be of type {typeof(T)}");
            Console.WriteLine("Each element of a seperate line.");
            Console.WriteLine("Add empty element to finish.");

            var numbers = new List<T>();

            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                T number = (T)Convert.ChangeType(input, typeof(T));
                numbers.Add(number);

                input = Console.ReadLine();
            }

            return numbers;
        }
    }
}