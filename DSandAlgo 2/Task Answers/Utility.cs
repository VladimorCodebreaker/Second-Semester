using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    public class Utility
    {
        public static IEnumerable<T> ReadSequenceOfElements<T>() where T : IComparable
        {
            Console.WriteLine("Please enter a sequence of elements.");
            Console.WriteLine($"Elements should be of type {typeof(T)}");
            Console.WriteLine("Each element on a seperate line.");
            Console.WriteLine("Add empty space to finish.");
            Console.WriteLine("--------------------------");

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