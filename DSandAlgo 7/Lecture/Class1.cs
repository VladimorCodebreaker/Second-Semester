using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_7.Lecture
{
    internal class Class1
    {
        public static void Input()
        {
            int[] bubbleArray = new int[] { 1, 3, 5, 6, 7, 8, 8, 8, 8, 7, 5, 4, 3, 2 };

            for (int i = 0; i < bubbleArray.Length; i++)
            {
                Console.WriteLine(bubbleArray[i]);
            }
            BubbleSort(bubbleArray);
        }

        public static void BubbleSort(int[] bubbleArray)
        {

            for (int i = 0; i < bubbleArray.Length; i++)
            {
                for (int j = 0; j < bubbleArray.Length; j++)
                {
                    if (bubbleArray[i] > bubbleArray[j])
                    {
                        int temp = bubbleArray[j];
                        bubbleArray[j] = bubbleArray[i];
                        bubbleArray[i] = temp;
                    }
                }
            }
            Print(bubbleArray);
        }

        public static void Print(int[] output)
        {
            Console.WriteLine("----------------------------Bubble Sorted Array----------------------");
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
