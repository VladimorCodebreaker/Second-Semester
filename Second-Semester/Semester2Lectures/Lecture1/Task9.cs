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
}
