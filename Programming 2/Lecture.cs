using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Lecture2
{
    internal class Lecture
    {
        public static void One()
        {
            string str = "abcde";
            char ch = str[1];
            Console.WriteLine(ch);
            Console.WriteLine(str[1]);

            string str1 = "His name is \"Bill Gates\"";
            Console.WriteLine(str1);

            string source = "Some source";
            string assigned = source;
            Console.Write("{0} and {1}", source, assigned);
            Console.WriteLine("\n");

            string word1 = "C#";
            string word2 = "c#";
            Console.WriteLine(word1.Equals("C#"));
            Console.WriteLine(word1.Equals(word2));
            Console.WriteLine(word1 == "C#");
            Console.WriteLine(word1 == word2);
            Console.WriteLine(word1.Equals(word2, StringComparison.CurrentCultureIgnoreCase));
            Console.WriteLine();

            string score = "sCore";
            string scary = "scary";
            Console.WriteLine(score.CompareTo(scary));
            Console.WriteLine(scary.CompareTo(score));
            Console.WriteLine(scary.CompareTo(scary));
            Console.WriteLine();

            string str2 = "Hello";
            string str3 = str2;
            Console.WriteLine(str2 == str3);
        }

        public static void Two()
        {
            string hello = "Hello";
            string same = "Hello";
            if (hello.Equals(same))
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Distinct");
            }
            Console.WriteLine();

            string greet = "Hello ";
            string name = "reader";
            string result = string.Concat(greet, name);
            Console.WriteLine("Result " + result);

            string _greet = "Hello, ";
            string _name = "reader!";
            string _result = _greet + _name;
            Console.WriteLine("Result: " + _result);
            Console.WriteLine();

            string Greet = "Hello";
            string Name = " reader!";
            string.Concat(Greet, Name); // Won't be displayed!

            string message = "The number of the beast is: ";
            int beastNum = 555;
            string Result = message + beastNum;
            Console.WriteLine("Result: " + Result);

            string str = "C# Programming Course";
            int index = str.IndexOf("C#"); // 0
            index = str.IndexOf("Course"); // 15
            index = str.IndexOf("COURSE"); // -1
            index = str.IndexOf("ram"); // 7
            index = str.IndexOf("r"); // 4
            index = str.IndexOf("r", 5); // 7
            index = str.IndexOf("r", 10); // 18
            Console.WriteLine(index);
            Console.WriteLine();

            string quote = "The main intent of the \"Intro C#\" " +
                "book is to introduce the C# programming to newbies";
            string keyword = "the";
            int Index = quote.IndexOf(keyword);
            while (Index != -1)
            {
                Console.WriteLine($"Key word \"{keyword}\" found at index {Index}");
                Index = quote.IndexOf(keyword, Index + 1);
            }
            Console.WriteLine("\n");

            string path = @"C:\\Pics\\CoolPics";
            string fileName = path.Substring(4, 4);
            Console.WriteLine(fileName);

            string listOfBeers = "Amstel, Heineken, Tuborg, Becks";
            char[] separators = new char[] { ' ', ',', '.' };
            string[] beersArray = listOfBeers.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (var elements in beersArray)
            {
                Console.Write(elements);
            }
            Console.WriteLine("\n");

            string doc = "Hello, some@gmail.com," +
                " you have been using some@gmail.com in your registration.";
            string fixedDoc = doc.Replace("some@gmail.com", "john@smith.com");
            Console.WriteLine(fixedDoc);
            Console.WriteLine("\n");

            string fileData = "   \n\n      David Allen";
            string reduced = fileData.Trim();
            Console.WriteLine(reduced);

            string fileData1 = " 111 $ %     David Allen  ### § ";
            char[] trimChars = new char[] { ' ', '1', '$', '%', '#', '§' };
            string _reduced = fileData1.Trim(trimChars);
            Console.WriteLine(_reduced);
            Console.WriteLine();
        }

        public static void Three()
        {
            //string doc = " Smith's number: 0898880022\n Franky can be" +
            //    "found at 0888445577.\n Steven's movile number: 0887542484";
            //string replacedDoc = Regex.Replace(
            //    doc, "(08)[0-9]{8}", "$1********");
            //Console.WriteLine("Replaced Document: \n" +
            //    "{0}", replacedDoc);
            //Console.WriteLine("\n");

            //string str = "Num: ";
            //Console.WriteLine(DateTime.Now);
            //for (int i = 0; i < 200000; i++)
            //{
            //    str += i;
            //}
            //Console.WriteLine(DateTime.Now);

            Console.WriteLine("\n");

            int num = 1;
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 200000; i++)
            {
                num += i;
            }
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("\n");

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello World: ");
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 200000; i++)
            {
                sb.Append(i);
            }
            Console.WriteLine(DateTime.Now);
        }
    }
}
