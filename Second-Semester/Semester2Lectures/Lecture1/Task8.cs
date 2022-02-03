using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Semester2Lectures.Lecture1
{
    class Task8
    {
        public static void Run()
        {
            var input = Input();

            string[] logic = Logic(input);

            Output(logic);
        }

        public static string[] Input()
        {
            Console.WriteLine("How many words would you like to input?");
            int inputSize = int.Parse(Console.ReadLine());

            string[] userInput = new string[inputSize];

            Console.WriteLine("Input {0} words please: ", inputSize);
            for (int i = 0; i < inputSize; i++)
            {
                userInput[i] = Console.ReadLine();
            }

            return userInput;
        }

        public static string[] Logic(string[] input)
        {
            string[] help = new string[1];

            for (int i = 0; i < input.Length - 1; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i].CompareTo(input[j]) > 0)
                    {
                        help[0] = input[i];
                        input[i] = input[j];
                        input[j] = help[0];
                    }
                }
            }
            Console.WriteLine();

            var addComma = string.Join(", ", input.ToArray());

            Console.WriteLine(addComma);

            return null;
        }
        public static void Output(string[] output)
        {
            Console.WriteLine(output);
        }
    }
}
