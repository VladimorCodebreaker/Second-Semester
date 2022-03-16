using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DSandAlgo_6._Lecture
{
    internal class StudentBookTest
    {
        SortedDictionary<Course, SortedSet<Student>> studentsBook = new SortedDictionary<Course, SortedSet<Student>>();

        public void Run()
        {
            LoadStudents();

            DisplayStudents();
        }

        private void DisplayStudents()
        {
            foreach (var record in studentsBook)
            {
                Console.Write($"{record.Key}: ");

                Console.Write($"{string.Join(", ", record.Value)}");

                Console.WriteLine();
            }
        }

        private void LoadStudents()
        {
            string fileContent = File.ReadAllText(@"C:\Meine Codes\Visual Studio 2019\Semester 2 Prime\DSandAlgo 6\_Lecture\TextFile1.txt");

            string[] fileArray = fileContent.Split(Environment.NewLine.ToCharArray());

            foreach (var line in fileArray)
            {
                if (!string.IsNullOrEmpty(line))
                {
                    string[] lineArray = line.Split('|');

                    string firstName = lineArray[0].Trim();
                    string lastName = lineArray[1].Trim();
                    string courseName = lineArray[2].Trim();

                    Student student = new Student(firstName, lastName);
                    Course course = new Course(courseName);

                    if (!studentsBook.ContainsKey(course))
                    {
                        studentsBook.Add(course, new SortedSet<Student>());
                    }
                    studentsBook[course].Add(student);
                }
            }
        }

    }
}
