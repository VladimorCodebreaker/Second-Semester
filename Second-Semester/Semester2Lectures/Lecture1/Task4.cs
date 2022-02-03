using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Semester2Lectures.Lecture1
{
    class Task4
    {
        public static void Run()
        {

            // Input
            var input = Input();

            // Logic
            var toOutput = Logic(input);

            // Output
            Output(toOutput);
        }

        public static string Input()
        {
            return "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight." +
                " So we are drinking all the day. We will move out of it in 5 days.";
        }

        public static string Logic(string input)
        {
            //Step 1: fragment phrase.
            var patternPhrase = @"(?<=(^|[.!?]\s*))[^ .!?][^.!?]+[.!?]";

            //Step 2: filter out only the phrases containing the word.
            var patternWord = @"submarine";

            var result = Regex
                .Matches(input, patternPhrase) // step 1
                .Cast<Match>()
                .Select(s => s.Value)
                .Where(w => Regex.IsMatch(w, patternWord, RegexOptions.IgnoreCase)); // step 2

            foreach (var item in result)
            {
                Console.WriteLine(item);
                //do something with any phrase.
            }

            return null;
        }

        public static void Output(string output)
        {
            Console.WriteLine(output);
        }
    }
}
