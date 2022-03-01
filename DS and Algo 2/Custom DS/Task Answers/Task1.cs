using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DS_and_Algo_2.Task_Answers
{
    public class Task1
    {
        public static void Run()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            input.ToString();

            var numbers = Utility.ReadSequenceOfElements<int>();

            int sumOfNumbers = numbers.Where(number => number > 0).Sum();
            double averageNumbers = numbers.Where(number => number > 0).Average();

            PrintResult(sumOfNumbers, averageNumbers);
        }

        public static void PrintResult(int sumofNumbers, double averageNumbers)
        {
            Console.WriteLine("Sum: " + sumofNumbers);
            Console.WriteLine("Average: " + averageNumbers);
        }
    }
}
