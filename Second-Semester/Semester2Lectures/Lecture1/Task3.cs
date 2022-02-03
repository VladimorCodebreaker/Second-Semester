using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Lectures.Lecture1
{
    class Task3
    {
        public static void Run()
        {
            string input = Input();
            string searchString = "in";

            int output = CountOfSubstring(input, searchString);

            Output(output);
        }

        public static string Input()
        {
            return "We are living in a yellow submarine.";
        }

        public static int CountOfSubstring(string input, string searchString)
        {
            var result = 0;

            int index = input.IndexOf(searchString);

            while (index != -1)
            {
                result++;
                index = input.IndexOf(searchString, index + 1, StringComparison.CurrentCultureIgnoreCase);
            }

            return result;
        }

        public static void Output(int output)
        {
            Console.Write($"The result is {output} occurences");
        }
    }
}
