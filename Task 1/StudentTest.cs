using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_1
{
    internal class StudentTest
    {
        public static void Run()
        {
            Student studentA = new Student("Mama", "Mama", "Mama", "Mama", "Mama", 12345);
            studentA.Print();

            Student studentB = new Student("Mama");
            studentB.Print();
        }
    }
}
