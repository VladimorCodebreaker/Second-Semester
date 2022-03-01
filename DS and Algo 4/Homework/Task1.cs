using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_4.Homework
{
    internal class Task1
    {
        public static void Run()
        {
            Input();
        }

        public static void Input()
        {
            double[] array = new double[] { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Logic(array);
        }

        public static void Logic(double[] array)
        {
            Dictionary<double, int> count = new Dictionary<double, int>();

            foreach (var element in array)
            {
                if (count.ContainsKey(element))
                {
                    count[element] += 1;
                }
                else
                {
                    count[element] = 1;
                }
            }

            Output(count);
        }

        public static void Output(Dictionary<double, int> output)
        {
            foreach (var element in output)
            {
                Console.WriteLine("{0} --> {1}", element.Key, element.Value);
            }
        }
    }
}
