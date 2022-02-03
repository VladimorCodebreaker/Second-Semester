using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Lectures.Lecture1
{
    class Task2
    {
        public static void Run()
        {
            // Input 
            string input = Input();

            // Logic
            bool output = CheckParenthesis(input);

            // Output
            Output(output);
        }
        public static bool CheckParenthesis(string input)
        {
            int index = input.IndexOf("(");

            if (index == -1)
            {
                index = input.IndexOf(")");

                if (index == -1)

                    return true;
                else
                    return false;
            }

            while (index != -1)
            {
                index = input.IndexOf(")", index + 1);
                if (index == -1)
                {
                    return false;
                }
                index = input.IndexOf("(", index + 1);

            }

            return true;
        }
        public static string Input()
        {
            Console.WriteLine("Input: ");
            return Console.ReadLine();
        }

        public static void Output(bool output)
        {
            Console.WriteLine("Expression parenthesis is: ");
            Console.WriteLine(output ? "OK" : "Not OK");
        }
    }
}
