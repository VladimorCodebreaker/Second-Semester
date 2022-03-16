using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo_6._Lecture
{
    internal class Course : IComparable<Course>, IEquatable<Course>
    {
        private string name { get; set; }

        public Course(string Name)
        {
            this.name = Name;
        }

        public int CompareTo(Course other)
        {
            return string.Compare(name, other.name, true);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Course);
        }

        public bool Equals(Course other)
        {
            if (other is null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return string.Compare(name, other.name, true) == 0;
        }

        public override int GetHashCode()
        {
            return !string.IsNullOrEmpty(name) ? name.GetHashCode() : 0;
        }

        public override string ToString()
        {
            return string.Format($"{name}");
        }
    }
}
