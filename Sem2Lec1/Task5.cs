using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Lec1
{
    class Task5
    {
        public static void Run()
        {
            // Input
            var input = Input();
            string[] arr = new string[] { "C#", "CLR", "Microsoft" };
            string txt = "C#";

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
            var wordOne = input.IndexOf(arr[0]);

            //if (wordOne.Equals(arr[0]))
            //{
            //    string.Replace(arr[0], "*");
            //}

            //char asterisk = '*';


            foreach (char c in input)
            {
                if (input.Contains(arr[0]))
                {
                    // input = input.Replace(, asterisk);
                }
                else if (input.Contains(arr[1]))
                {

                }
                else if (input.Contains(arr[2]))
                {

                }
            }

            #region Use Linq
            //var arr = new string[] { "C#", "CLR", "Microsoft" };
            //var input = "Microsoft announced its next generation C# compiler today. It uses advanced parser and special optimizer for the Microsoft CLR";
            //var filteredInput = arr.Aggregate(input, (result, word) => result.Replace(word, "*"));
            //Console.WriteLine(filteredInput);
            #endregion
            return input;
        }

        public static void Output(string output)
        {
            Console.WriteLine("Changed sentence: {0}", output);
        }
    }
}
