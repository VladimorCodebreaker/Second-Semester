using System;
namespace DSandAlgo_8.Homework
{
    public class Task_2
    {
        public static void Permutation(int[] arr, int index, int possibilities) // Possibilities == n
        {
            if (index >= arr.Length)
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    if (i < arr.Length)
                    {
                        Console.Write(arr[i]);
                    }
                }
                Console.Write(", ");
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

        public static void Run()
        {
            int n = 3;
            int k = 3;
            int[] arr = new int[k]; // k Number of items per combination

            Permutation(arr, 0, n); // n = number of possibilities
        }
    }
}
