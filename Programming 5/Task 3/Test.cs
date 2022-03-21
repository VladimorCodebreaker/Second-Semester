using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_5.Task_3
{
    internal class Test
    {
        public static void Run()
        {
            Student[] studentList;

            Student studentA = new Student("Michael", 2.324f);
            Student studentB = new Student("Frederick", 3.442f);
            Student studentC = new Student("Marianne", 5.55f);
            Student studentD = new Student("Lena", 1.444f);
            Student studentE = new Student("Anna", 2.333f);

            studentList = new Student[] { studentA, studentB, studentC, studentD, studentE };

            Console.WriteLine("--------------------Unsorted list of students----------------\n");
            foreach (var item in studentList)
            {
                Console.WriteLine(item);
            }

            SortedSet<Student> sortedList = new SortedSet<Student>();
            foreach (var item in studentList)
            {
                sortedList.Add(item);
            }

            Console.WriteLine("--------------------Sorted list of students----------------\n");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
