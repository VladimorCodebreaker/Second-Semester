using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace DSandAlgo_5.Homework
{
    internal class Task_3
    {
        public static void Run()
        {
            Input();
        }

        public static void Input()
        {
            string str = File.ReadAllText(@"C:\Meine Codes\Visual Studio 2019\Semester 2\DSandAlgo 5\Homework\Text.txt");  // User ReadAllText to copy the file's text into a string

            Occurrences(str);
        }

        public static void Occurrences(string str)
        {
            string textToLower = str.ToLower();                                         // Converts the string to lower case string
            Regex reg_exp = new Regex("[^a-z0-9]");                                     // Regular expressions to replace non-letter and non-number characters with spaces. It uses the pattern [^a-z0-9].The a-z0-9 part means any lowercase letter or a digit.
            textToLower = reg_exp.Replace(textToLower, " ");                            // The code uses the Regex object’s Replace method to replace the characters that match the pattern with a space character. 
            string[] Value = textToLower.Split(new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries);                                     // Split the string and remove the empty entries

            Dictionary<string, int> CountTheOccurrences = new Dictionary<string, int>(); // Create a dictionary to keep track of each occurrence of the words in the string
            for (int i = 0; i < Value.Length; i++)                                       // Loop the splited string  
            {
                if (CountTheOccurrences.ContainsKey(Value[i]))                           // Check if word is already in dictionary update the count  
                {
                    int value = CountTheOccurrences[Value[i]];
                    CountTheOccurrences[Value[i]] = value + 1;
                }
                else                                                                     // If we found the same word we just increase the count in the dictionary 
                {
                    CountTheOccurrences.Add(Value[i], 1);
                }
            }


            Output(CountTheOccurrences);
        }

        public static void Output(Dictionary<string, int> output)
        {
            Console.WriteLine("The number of counts for each word are:");
            foreach (KeyValuePair<string, int> pair in output)
            {
                Console.WriteLine("Counts: " + pair.Value + " for " + pair.Key); // Print the number of counts for each word
            }
        }
    }

}
