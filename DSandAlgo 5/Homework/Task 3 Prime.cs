using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
namespace DSandAlgo_5.Homework
{
    internal class Task_3_Prime
    {
        public static void Run()
        {
            string str = @"C:\Meine Codes\Visual Studio 2019\Semester 2\DSandAlgo 5\Homework\Text.txt";
            PrintWordCountsInFile(str);
        }

        /// <summary>
        /// Convenience method which prints the number of occurrences of each word in the given file
        /// </summary>
        public static void PrintWordCountsInFile(string fileName)
        {
            var text = System.IO.File.ReadAllText(fileName);
            var words = SplitWords(text);
            var counts = CountWordOccurrences(words);
            WriteWordCounts(counts, System.Console.Out);
        }

        /// <summary>
        /// Splits the given text into individual words, stripping punctuation
        /// A word is defined by the regex @"\p{L}+"
        /// </summary>
        public static IEnumerable<string> SplitWords(string text)
        {
            Regex wordMatcher = new Regex(@"\p{L}+");
            return wordMatcher.Matches(text).Cast<Match>().Select(c => c.Value); // You get an IEnumerable of Match objects (Cast<Match>)
        }

        /// <summary>
        /// Counts the number of occurrences of each word in the given enumerable
        /// </summary>
        public static IDictionary<string, int> CountWordOccurrences(IEnumerable<string> words)
        {
            return CountOccurrences(words, StringComparer.CurrentCultureIgnoreCase);
        }

        /// <summary>
        /// Prints word-counts to the given TextWriter
        /// </summary>
        public static void WriteWordCounts(IDictionary<string, int> counts, TextWriter writer)
        {
            writer.WriteLine("The number of counts for each words are:");
            foreach (KeyValuePair<string, int> pair in counts)
            {
                writer.WriteLine("Counts: " + pair.Value + " for " + pair.Key.ToLower()); // print word in lower-case for consistency
            }
        }

        /// <summary>
        /// Counts the number of occurrences of each distinct item
        /// </summary>
        public static IDictionary<T, int> CountOccurrences<T>(IEnumerable<T> items, IEqualityComparer<T> comparer)
        {
            var counts = new Dictionary<T, int>(comparer);

            foreach (T t in items)
            {
                int count;
                if (!counts.TryGetValue(t, out count))
                {
                    count = 0;
                }
                counts[t] = count + 1;
            }

            return counts;
        }
    }
}
