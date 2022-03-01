using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_and_Algo_4.Lecture
{
    internal class Point : IComparable<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CompareTo(Point otherPoint)
        {
            if (X != otherPoint.X)
            {
                return X.CompareTo(otherPoint.X);
            }
            else
            {
                return Y.CompareTo(otherPoint.Y);
            }
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Point) || (obj == null)) return false;

            Point p = (Point)obj;

            return (X == p.X) && (Y == p.Y);
        }

        public override int GetHashCode()
        {
            return (X << 16 | X >> 16) ^ Y;
        }
    }
}
