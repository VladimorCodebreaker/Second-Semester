using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_5.Task_4
{
    internal class Worker : Human, IComparable<Worker>
    {
        private int salary;
        public int Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public Worker(string name, int _salary) : base(name)
        {
            this.salary = _salary;
        }

        public int CompareTo(Worker other)
        {
            return this.salary.CompareTo(other.salary);
        }

        public override string ToString()
        {
            return base.ToString() + this.salary;
        }

    }
}
