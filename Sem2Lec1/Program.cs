using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem2Lec1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1.Run();
            //Task2.Run();
            //Task3.Run();
            //Task4.Run();
            //Task5.Run(); // Has to be revised
            //Task6.Run();
            //Task7.Run();
            //Task8.Run();
            //Task9.Run();
            //Run();

        }

        #region 
        public static void Run()
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            int size = array.Count();

            Sort(array, size);
            Print(array, size);
        }
        public static void Sort(int[] array, int size)
        {
            int temp = 0;

            for (int i = 0; i < size - 1; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public static void Print(int[] array, int size)
        {
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }
        }
        #endregion
    }
}
