using System;
namespace DSandAlgo_8.Lecture
{
    public class Permutation
    {
        public static void DoStuff()
        {
            List<string> possibilities = new List<string>() { "0", "1"};
            List<string> permutations = new List<string>();

            int digits = 2;

            Permute(permutations, possibilities, digits, "");
            Print(permutations);
        }

        private static void Permute(List<string> permutations, List<string> possibilities, int digitsLeft, string current)
        {
            Console.WriteLine("step: " + current);

            if (digitsLeft < 0)
            { return; }

            if (digitsLeft == 0)
            {
                permutations.Add(current);
                return;
            }

            foreach (var item in possibilities)
            {
                Permute(permutations, possibilities, digitsLeft - 1, current + item);
            }
        }

        public static void Print(List<string> permutations)
        {
            Console.WriteLine("---------Print----------\n");
            foreach (var element in permutations)
            {
                Console.WriteLine(element);
            }
        }
    }
}

