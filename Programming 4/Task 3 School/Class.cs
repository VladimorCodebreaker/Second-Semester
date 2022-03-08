using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_3_School
{
    internal class Class
    {
        private string textIdentifier { get; set; }
        private int numberOfTeachers { get; set; }


        public Teacher teacher { get; set; }
        private List<Student> studentList = new List<Student>();

        public Class() : this("aldkaljawld")
        {
        }

        public Class(string TextIdentifier) : this("kalawkda", 1)
        {
            this.textIdentifier = TextIdentifier;
        }

        public Class(string TextIdentifier, int NumberOfTeachers)
        {
            this.textIdentifier = TextIdentifier;
            this.numberOfTeachers = NumberOfTeachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teacher = teacher;
        }

        public void AddStudent(Student student)
        {
            studentList.Add(student);
        }

        public override string ToString()
        {
            Console.WriteLine("----------------------Teacher--------------------");

            foreach (Discipline element in teacher.listOfDisciplines)
            {
                Console.WriteLine(element.ToString());
            }

            Console.WriteLine("----------------------Students--------------------");

            foreach (Student student in studentList)
            {
                Console.WriteLine(student.ToString());
            }

            Console.WriteLine("----------------------Subject--------------------");

            var random = new Random();
            int index = random.Next(teacher.listOfDisciplines.Count);

            Console.WriteLine(teacher.listOfDisciplines[index]);

            return null;
        }
    }
}
