using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Lectures.Lecture1
{
    class Task1
    {
        public static void Run()
        {
            // Input 
            string input = Input();

            // Logic
            string output = ReverseString(input);

            // Output
            Output(output);
        }
        private static string Input()
        {
            Console.WriteLine("Please enter a string: ");
            return Console.ReadLine();
        }

        private static string ReverseString(string input)
        {
            var result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }

        private static void Output(string output)
        {
            Console.WriteLine("Reverse version of that string is: ");
            Console.WriteLine(output);
        }
    }
}
