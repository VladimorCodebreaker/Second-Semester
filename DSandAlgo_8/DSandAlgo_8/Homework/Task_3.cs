using System;
using System.Text;

namespace DSandAlgo_8.Homework
{
    public class Task_3
    {
        private static string[] resizedArray = new string[] { };

        public static void Permutation(int[] arr, int index, int possibilities)
        {
            if (index >= arr.Length)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <= possibilities; i++)
                {
                    arr[index] = i;
                    Permutation(arr, index + 1, possibilities);
                }
            }
        }

        public static void Print(int[] arr)
        {
            StringBuilder txt = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                txt.Append(arr[i] + ",");
            }

            resizedArray = txt.ToString().Split(',', StringSplitOptions.RemoveEmptyEntries);
            IEnumerable<string> distinctArr = resizedArray.Distinct().ToArray();

            foreach (var element in distinctArr)
            {
                Console.Write(element);
            }
            Console.Write(", ");
        }

        public static void Run()
        {
            int n = 4; // possibilities
            int k = 2; // capacity of the array
            int[] arr = new int[k];

            Permutation(arr, 0, n);
        }
    }
}


