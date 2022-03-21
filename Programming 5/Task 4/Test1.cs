using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_5.Task_4
{
    internal class Test1
    {
        public static void Run()
        {
            Worker[] workerArray;

            Worker workerA = new Worker("John", 2432);
            Worker workerB = new Worker("Sarah", 3243);
            Worker workerC = new Worker("Alli", 2452);
            Worker workerD = new Worker("Will", 3243);
            Worker workerE = new Worker("Abdul", 9483);

            workerArray = new Worker[] { workerA, workerB, workerC, workerD, workerE };

            Console.WriteLine("---------------------------------Unsorted Array of Workers-------------------------\n");
            foreach (var item in workerArray)
            {
                Console.WriteLine(item.ToString());
            }

            Array.Sort(workerArray);
            Array.Reverse(workerArray);

            Console.WriteLine("---------------------------------Sorted Array of Workers in DESCENDENT order-------------------------\n");
            foreach (var item in workerArray)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
