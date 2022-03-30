using System;
namespace DSandAlgo_8.Homework
{
    public class Task_6
    {
        public static void Run()
        {
            var combinations = CombinationGenerator(new string[] { "test", "rock", "fun" }, 2);
            combinations.ForEach(x => Console.WriteLine($"({x})"));
        }

        private static List<string> CombinationGenerator(string[] inputWords, int? maxWordsPerCombination = 2)
        {
            var combinations = new List<string> { "" };
            CombinationGenerator(inputWords, "", maxWordsPerCombination ?? inputWords.Length, combinations);
            return combinations;
        }

        private static void CombinationGenerator(IEnumerable<string> inputWords, string prefix, int maxWordsPerCombination, IList<string> combinations)
        {
            if (inputWords.Count() == 0 || maxWordsPerCombination == 0)
            {
                return;
            }

            foreach (var word in inputWords)
            {
                CombinationGenerator(inputWords.Where(x => x != word), prefix + word + " ", maxWordsPerCombination - 1, combinations);
                combinations.Add(prefix + word);
            }
        }
    }
}
