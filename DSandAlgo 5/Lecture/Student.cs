using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_5.Lecture
{
    public class Student : IComparable
    {
        public string Name { get; set; }
        public int Priority { get; set; }
    
        public int CompareTo(object obj)
        {
            var otherStudent = (Student)obj;

            if (otherStudent.Priority < this.Priority)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"Name: {Name} Priority: {Priority}";
        }
    }
}
