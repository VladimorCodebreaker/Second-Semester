using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_5.Task_3
{
    internal class Student : Human, IComparable<Student>
    {
        private float mark;

        public float Mark
        {
            get { return this.mark; }
            set { this.mark = value; }
        }
        public Student(string _name, float _mark) : base(_name)
        {
            this.mark = _mark;
        }

        public int CompareTo(Student other)
        {
            return this.mark.CompareTo(other.mark);
        }

        public override string ToString()
        {
            return this.mark.ToString() + " | | " + base.ToString();
        }
    }
}
