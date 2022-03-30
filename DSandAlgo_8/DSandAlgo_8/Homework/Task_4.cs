using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Globalization;

/*Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for given integer number n. Example:
	n = 3 -> { 1, 2, 3}, { 1, 3, 2}, { 2, 1, 3},{ 2, 3, 1}, { 3, 1, 2},{ 3, 2, 1}*/

namespace DSandAlgo_8.Homework
{
    public class Task_4
    {

        public static void Run()
        {
            Console.WriteLine("Input the number of possible permutations from 1,2..n");
            bool read = int.TryParse(Console.ReadLine(), out int n);

            int[] arr = new int[n];

            Logic(arr, 0);
        }

        public static void Logic(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                Print(arr);
            }
            else
            {
                for (int i = 1; i <= arr.Length /* = n */; i++)
                {
                    arr[index] = i;
                    Logic(arr, index + 1);
                }
            }
        }

        public static void Print(int[] arr)
        {
            foreach (var element in arr)
            {
                Console.Write(element);
            }
            Console.Write(", ");
        }
    }
}

