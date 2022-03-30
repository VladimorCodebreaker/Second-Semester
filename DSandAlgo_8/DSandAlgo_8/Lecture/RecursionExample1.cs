using System;
namespace DSandAlgo_8.Lecture
{
    public class RecursionExample1
    {
        public static void Run()
        {
            // Method(0);
            //Method1("txt");
            Console.WriteLine(ReverseString("Rogenwalzer Brötchen"));
        }

        public static void Method(int someValue)
        {
            if (someValue == 10)
            {
                Console.WriteLine(someValue);
                return;
            }
            Method(someValue + 1);
        }
        
        public static bool Method1(string someValue)
        {
            Console.Write(someValue);
            return Method1(someValue);
        }

        public static string ReverseString(string text)
        {
            var words = text.Split(' ');
            return words.Length == 1
               ? new string(words[0].Reverse().ToArray()) // Not recursive; using Enumerable.Reverse()
               : string.Join(" ", words.Select(ReverseString)); // <- Here's the recursive call.
        }
    }
}

