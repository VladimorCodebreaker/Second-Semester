using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semester2Lectures.Lecture1
{
    class Task9
    {
        public static void Run()
        {
            Input();
            // Input calls Logic calls Output and passes in what's needed
        }

        public static void Input()
        {
            Console.WriteLine("How many words would you like to input? ");
            bool inputSize = int.TryParse(Console.ReadLine(), out int input);

            string[] myArr = new string[input];

            Console.WriteLine("Please input {0} amount of strings into the array!", input);
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = Console.ReadLine();
            }

            Logic(myArr);
        }

        public static void Logic(string[] myArr)
        {
            // Sort 
            string[] help = new string[1];

            for (int i = 0; i < myArr.Length - 1; i++)
            {
                for (int j = i + 1; j < myArr.Length; j++)
                {
                    if (myArr[i].CompareTo(myArr[j]) > 0)
                    {
                        help[0] = myArr[i];
                        myArr[i] = myArr[j];
                        myArr[j] = help[0];
                    }
                }
            }
            // Count
            var count = ((char)myArr.Count());

            Console.WriteLine("\n");

            Output(myArr, count);
        }

        public static void Output(string[] myArr, int count)
        {
            Console.WriteLine("Count of elements in the array: " + count);
            Console.WriteLine("\n");

            foreach (string element in myArr)
            {
                Console.WriteLine(element);
            }
        }
    }

    class Task9_Prime
    {
        public static void Run()
        {
            Input();
        }

        public static void Input()
        {
            string input = "We are living in a 1.2 yellow submarine." +
                " We don't have anything else. " +
                "Inside the submarine is very tight. " +
                "So we are drinking all the day. " +
                "We will move out of submarine in 5 days.";

            SortArray(input);
        }
        public static void SortArray(string input)
        {
            var charArray = input.ToCharArray();
            // Sort
            char[] help = new char[1];

            for (int i = 0; i < charArray.Length - 1; i++)
            {
                for (int j = i + 1; j < charArray.Length; j++)
                {
                    if (charArray[i].CompareTo(charArray[j]) > 0)
                    {
                        help[0] = charArray[i];
                        charArray[i] = charArray[j];
                        charArray[j] = help[0];
                    }
                }
            }

            CountOccurences(charArray);
        }

        public static void CountOccurences(char[] array)
        {
            Dictionary<char, int> occurences = new Dictionary<char, int>();
            foreach (char c in array)
            {
                if (occurences.ContainsKey(c))
                {
                    occurences[c]++;
                }
                else
                {
                    occurences.Add(c, 1);
                }
            }

            Output(array, occurences);
        }
        public static void Output(char[] output, Dictionary<char, int> occurences)
        {
            foreach (char c in occurences.Keys)
            {
                Console.WriteLine(c + "-" + occurences[c]); 
            }
            foreach (char c in output)
            {
                Console.Write(c);
            }
        }
    }
}
