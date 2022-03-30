using System;
namespace DSandAlgo_8.Homework
{
    public class Task_1
    {
        public static void Run()
        {
            int[] arr = new int[3];

            Logic(arr, 0);
        }

        public static void Logic(int[] arr, int index)
        {
            int end = 1; int start = 0;

            if (index >= arr.Length)
            {
                Print(arr);
            }
            else
            {
                for(start = 0; start <= end; start++)
                {
                    arr[index] = start;
                    Logic(arr, index + 1);
                }
            }
        }

        private static void Print(int[] output)
        {
            Console.WriteLine("--------Loop---------");
            foreach (var element in output)
            {
                Console.WriteLine(element);
            }
        }
    }
}

