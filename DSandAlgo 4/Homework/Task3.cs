using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_and_Algo_4.Homework
{
    internal class Task3
    {
        public static void Run()
        {
            Input();
        }

        private static void Input()
        {
            string file = @"C:\Meine Codes\Visual Studio 2019\Semester 2\DS and Algo 4\Homework\TextFile1.txt";

            string str = File.ReadAllText(file);
            Console.WriteLine(str);

            Logic(str);
        }

        private static void Logic(string input)
        {
            //int count = 0;

            string[] words = input.Split(' ', '.', ',');

            //foreach (var word in words)
            //{
            //    foreach (var wurd in words)
            //    {
            //        if (string.Equals(word, wurd, StringComparison.InvariantCultureIgnoreCase))
            //        {
            //            count++;
            //            Console.WriteLine(word + count);
            //        }
            //    }
            //}
            //Output(count);

            Dictionary<string, int> count = new Dictionary<string, int>(StringComparer.InvariantCultureIgnoreCase);

            foreach (var element in words)
            {
                if (count.ContainsKey(element))
                {
                    count[element] += 1;
                }
                else
                {
                    count[element] = 1;
                }
            }

            Output(count);
        }

        private static void Output(Dictionary<string, int> output)
        {
            foreach (KeyValuePair<string, int> pair in output)
            {
                Console.WriteLine("{0} ==> {1}", pair.Key, pair.Value);
            }
        }
    }
}
