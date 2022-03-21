using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_7.Homework
{
    internal class Task_5 // Linear Search
    {
        private static int Search(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public static void Run()
        {
            int[] arr = { 2, 3, 4, 10, 40 };
            int x = 10;

            int result = Search(arr, x);

            if (result == -1)
            {
                throw new Exception("Element is not present in the array");
            }
            else
            {
                Console.WriteLine("Element is at index: {0}", result);
            }
        }
    }
}
