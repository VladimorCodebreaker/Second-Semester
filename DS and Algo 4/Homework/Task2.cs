using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_4.Homework
{
    internal class Task2
    {
        public static void Run()
        {
            string[] input = Input();

            SortedSet<string> logic = Logic(input);

            Output(logic);
        }

        private static string[] Input()
        {
            string[] array = new string[] { "C#", "SQL", "PHP", "PHP", "SQL", "SQL" };
            return array;
        }
        
        private static SortedSet<string> Logic(string[] input)
        {
            SortedSet<string> extractedElements = new SortedSet<string>();

            int count = 0;
            foreach (var element in input)
            {
                foreach (var value in input)
                {
                    if (element == value)
                    {
                        count++;
                    }
                }

                if (count % 2 != 0)
                {
                    extractedElements.Add(element);
                }
            }
            return extractedElements;
        }

        private static void Output(SortedSet<string> Output)
        {
            foreach (string element in Output)
            {
                Console.WriteLine(element);
            }
        }
    }
}
