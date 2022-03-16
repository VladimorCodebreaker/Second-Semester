using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace DSandAlgo_6.Task_1
{
    internal class Task_1
    {
        public static SortedDictionary<string, SortedSet<string>> sortedStudents = new SortedDictionary<string, SortedSet<string>>();

        public static void Input()
        {
            string input = File.ReadAllText(@"C:\Meine Codes\Visual Studio 2019\Semester 2 Prime\DSandAlgo 6\Homework\TextFile1.txt");
            Logic(input);
        }

        public static void Logic(string input)
        {
            string firstName = null, lastName = null, course = null;
            string[] lines = Regex.Split(input, Environment.NewLine);

            Student studentA;
            Course courseA;

            foreach (string line in lines)
            {
                string[] splitLine = line.Split('|', (char)StringSplitOptions.RemoveEmptyEntries);

                firstName = splitLine[0].Trim();
                lastName = splitLine[1].Trim();
                course = splitLine[2].Trim();

                //sortedStudents.Add
            }
        }


        public static void Output()
        {

        }
    }

    internal class Student
    {
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Student(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }

    internal class Course
    {
        private string course { get; set; }

        public Course(string Course)
        {
            this.course = Course;
        }

        public override string ToString()
        {
            return this.course + " : ";
        }
    }
}


