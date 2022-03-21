using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_7.Homework
{
    internal class Task_2
    {
        public static void Input()
        {
            int[] arr = { 64, 25, 12, 22, 11 };

            SelectionSort(arr);
            CustomeSelectionSort(arr);
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Print(arr);
        }

        public static void CustomeSelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;
            }

            Print(arr);
        }

        public static void Print(int[] arr)
        {
            Console.WriteLine("-------------Selection sort--------");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
