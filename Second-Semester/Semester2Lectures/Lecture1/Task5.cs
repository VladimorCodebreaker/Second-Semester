using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Lectures.Lecture1
{
    class Task5
    {
        public static void Run()
        {
            // Input
            var input = Input();
            string[] arr = new string[] { "C#", "CLR", "Microsoft" };

            // Logic
            var logic = Logic(input, arr);

            // Output
            Output(logic);
        }

        public static string Input()
        {
            return "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR";
        }

        public static string Logic(string input, string[] arr)
        {
            var filteredInput = arr.Aggregate(input, (result, word) => result.Replace(word, "*"));

            return filteredInput;
        }

        public static void Output(string output)
        {
            Console.WriteLine("Changed sentence: {0}", output);
        }
    }
}
