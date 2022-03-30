using System;
namespace DSandAlgo_8.Lecture
{
    public class GetCombinations
    {
        public static void Logic(int[] arr, int index, int start, int end)
        {
            if (index >= arr.Length)
            {
                Console.Write("(");
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
                    {
                        Console.Write("{0}", arr[i]);
                    }
                    else
                    {
                        Console.Write(arr[i]);
                        Console.Write("), ");
                    }
                }
            }
            else
            {
                for (int i = start; i <= end; i++)
                {
                    arr[index] = i;
                    Logic(arr, index + 1, i, end);
                }
            }
        }

        public static void Test()
        {
            Console.Write("Enter n: ");
            bool n = int.TryParse(Console.ReadLine(), out int tryN); // end
            Console.Write("Enter k: ");
            bool k = int.TryParse(Console.ReadLine(), out int tryK);

            int[] arr = new int[tryK];

            Logic(arr, 0, 1, tryN);
        }
    }
}

