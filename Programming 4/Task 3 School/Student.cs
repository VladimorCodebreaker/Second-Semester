using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_4.Task_3_School
{
    internal class Student
    {
        private string name { get; set; }
        private int classNumber { get; set; }

        public Student(string Name, int ClassNumber)
        {
            this.name = Name;
            this.classNumber = ClassNumber;
        }

        public override string ToString()
        {
            return name + " " + classNumber;
        }
    }
}
