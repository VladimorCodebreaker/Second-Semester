using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student[] students = new Student[10];

            //students[0] = new Student { StudentNumber = 1, Name = "Ivan" };
            //students[1] = new Student { StudentNumber = 2, Name = "John" };
            //students[2] = new Student { StudentNumber = 3, Name = "Jane" };
            //students[3] = new Student { StudentNumber = 4, Name = "Marie" };
            //students[4] = new Student { StudentNumber = 5, Name = "Erman" };
            //students[5] = new Student { StudentNumber = 6, Name = "Islam" };


            //var s1 = Search(students, 1);

            //var s2 = Search(students, 5);

            Exercise2 count = new Exercise2();
            int[,] array = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine(count.Complexity(array));

            Exercise2.Matrix();

            //Exercise3 _count = new Exercise3();
            //int[,] _array = new int[3, 4];
            //_count.Calcsum(_array, 2);
        }

        private static Student Search(Student[] students, int studentNumber)
        {
            foreach (var student in students)
            {
                if (student.StudentNumber == studentNumber)
                {
                    return student;
                }
            }
            return null;
        }


    }
    
}
