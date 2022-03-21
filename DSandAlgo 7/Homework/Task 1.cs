using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_7.Homework
{
    internal class Task_1
    {
        private static Random random = new Random();
        public static void SortedArray()
        {
            int[] array = new int[] { 2, 3, 5, 6, 7, 3, 6, 7, 4, 3, 2, 5, 6, 8, 5, 4 };

            Array.Sort(array);

            Console.WriteLine("-------------------------------Sorted array-----------------------");
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }

            ShuffleArray(array);
            CustomShuffleArray(array);
        }

        public static void ShuffleArray(int[] array)
        {

            var randomArray = array.OrderBy(x => random.Next());
            
            Console.WriteLine("-------------------------------Shuffled array-----------------------");
            foreach (var item in randomArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void CustomShuffleArray(int[] array)
        {

        }
    }
}
