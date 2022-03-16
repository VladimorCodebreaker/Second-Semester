using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace DSandAlgo_6._Lecture
{
    internal class Student : IComparable<Student>
    {
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Student(string FirstName, string LastName)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
        }

        public int CompareTo(Student other)
        {
            var compare = lastName.CompareTo(other.lastName);

            if (compare == 0)
            {
                compare = firstName.CompareTo(other.firstName);
            }
            return compare;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }
    }
}
