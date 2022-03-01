using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_2.Task_Answers
{
    internal class Task4
    {
        public static void Run()
        {
            var numbers = Utility.ReadSequenceOfElements<int>().ToList();

            var longestSubsequence = FindLongestSubsequence(numbers);

            PrintResult(numbers, longestSubsequence);
        }
        public static IList<T> FindLongestSubsequence<T>(IList<T> sequence) where T : IComparable
        {
            if (sequence == null || sequence.Count == 0)
            {
                throw new ArgumentException("Sequence collection cannot be null or empty.");
            }

            T bestElement = sequence[0];
            int bestOccurs = 1;

            T currentBestElement = sequence[0];
            int currentOccurs = 1;

            for (int i = 1; i < sequence.Count; i++)
            {
                if (currentBestElement.CompareTo(sequence[i]) == 0)
                {
                    currentOccurs++;
                    if (currentOccurs >= bestOccurs)
                    {
                        bestOccurs = currentOccurs;
                        bestElement = currentBestElement;
                    }
                }

                if (currentBestElement.CompareTo(sequence[i]) != 0)
                {
                    currentBestElement = sequence[i];
                    currentOccurs = 1;
                }
            }

            if (currentBestElement.CompareTo(bestElement) != 0 && currentOccurs >= bestOccurs)
            {
                bestElement = currentBestElement;
                bestOccurs = currentOccurs;
            }

            var longestSubsequence = Enumerable.Repeat(bestElement, bestOccurs).ToList();
            return longestSubsequence;
        }

        public static void PrintResult<T>(IList<T> sequence, IList<T> longestSubsequence) where T : IComparable
        {
            Console.WriteLine(string.Join(" ", sequence) + " ->" + string.Join(" ", longestSubsequence));
        }
    }
}
