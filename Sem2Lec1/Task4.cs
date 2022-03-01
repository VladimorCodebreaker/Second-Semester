using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Lec1
{
    class Task4
    {
        public static void Run()
        {

            // Input
            var input = Input();
            string word = "Submarine";

            // Logic
            var toOutput = Logic(input, word);

            // Output
            Output(toOutput);
        }

        public static string Input()
        {
            return "We are living in a yellow submarine. We don't have anything else. " +
                "Inside the submarine is very tight. So we are drinking all the day. We " +
                "will move out of it in 5 days.";
        }

        public static string Logic(string input, string word)
        {
            int startIndex = 0;
            int length = 0;
            int dotIndex = 0;
            string sentence = string.Empty;

            int index = input.IndexOf(word);

            while (index != -1)
            {
                dotIndex = input.IndexOf(".", index + 1);
                length = dotIndex - startIndex + 1;

                sentence += input.Substring(startIndex, length) + Environment.NewLine;

                startIndex = dotIndex + 1;

                index = input.IndexOf(word, dotIndex + 1, StringComparison.InvariantCultureIgnoreCase);
            }

            return sentence;
        }

        public static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }


}
