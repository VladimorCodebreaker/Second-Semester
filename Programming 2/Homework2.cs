using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lecture2
{
    internal class Homework2
    {
        public static void Run()
        {
            Input();
        }

        static void Input()
        {
            string input = "<html>\n" +
                "<head><title>News</title></head>\n" +
                "<body><p><a href=\"http://vum.com\">VUM</a>aims to\n" +
                "provide free real-world practical\n" +
                "training for young people who want to turn into\n" +
                "skillfull software engineers.</p></body>\n" +
                "</html> ";

            RegExpression(input);

            RegexCompiled(input);

            CharArray(input);
        }

        /// <summary>
        ///  Using a regular expression.
        /// </summary>
        static void RegExpression(string input)
        {
            #region
            //string pattern = "<([a-z]+)[^>]*(?<!/)>";
            //MatchCollection matches = Regex.Matches(input, pattern);
            //Console.WriteLine("Matches found: {0}", matches.Count);

            //if (matches.Count > 0)
            //{
            //    foreach (Match m in matches)
            //    {
            //        Console.WriteLine("{0}", m.Groups[0]);
            //    }
            //}
            //Console.ReadKey();
            #endregion
            string regex = "<.*?>";

            string extractedText = Regex.Replace(input, regex, " ");

            Console.WriteLine("Extracted text: \n\n {0}", extractedText.TrimStart());
        }

        /// <summary>
        /// Using compiled regex. Gives a better performance
        /// </summary>
        static Regex regexCompiled = new Regex("<.*?>", RegexOptions.Compiled);
        static void RegexCompiled(string input)
        {
            string output = regexCompiled.Replace(input, string.Empty);
            Console.WriteLine(output);
        }

        /// <summary>
        /// Remove HTML tags using a char array
        /// </summary>
        static void CharArray(string input)
        {
            char[] array = new char[input.Length];
            int arrayIndex = 0;
            bool tag = false;

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '<')
                {
                    tag = true;
                    continue;
                }
                if (ch == '>')
                {
                    tag = false;
                    continue;
                }
                if (!tag)
                {
                    array[arrayIndex] = ch;
                    arrayIndex++;
                }
            }
            Console.WriteLine(array, 0, arrayIndex);
        }
    }
}
