using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Lec1
{
    class Task7
    {
        public static void Run()
        {
            var input = Input();

            var logic = Logic(input);

            Output(logic);
        }

        public static string Input()
        {
            return "aaaaabbbbcdddeeeedssaa";
        }

        public static string Logic(string input)
        {
            string s = string.Empty;

            var removeDuplicates = new SortedSet<char>(input);
            foreach (char c in removeDuplicates)
            {
                s += c;
            }

            return s;
        }
        public static void Output(string output)
        {
            Console.WriteLine("Removed duplicates: {0}", output);
        }
    }
}
