using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_3_School
{
    internal class TestSchool
    {
        public static void ClassOne()
        {
            Discipline dis1 = new Discipline("Biology", 10, 67);
            Discipline dis2 = new Discipline("Math", 25, 129);
            Discipline dis3 = new Discipline("Physics", 17, 56);


            Teacher teacher1 = new Teacher();
            teacher1.Add(dis1);
            teacher1.Add(dis2);
            teacher1.Add(dis3);

            Student student1 = new Student("Frederick", 1);
            Student student2 = new Student("Paul", 2);
            Student student3 = new Student("Maria", 3);
            Student student4 = new Student("Bogdanov", 4);
            Student student5 = new Student("Emiliano", 5);

            Class class1 = new Class("aklda", 1);

            class1.AddTeacher(teacher1);

            class1.AddStudent(student1);
            class1.AddStudent(student2);
            class1.AddStudent(student3);
            class1.AddStudent(student4);
            class1.AddStudent(student5);

            class1.ToString();
        }
    }
}
