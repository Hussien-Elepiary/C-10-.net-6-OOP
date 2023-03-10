using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace First_Project
{
    public class Point:ICloneable,IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
            Z = point.Z;
        }

        public Point(int _X)
        {
            X = _X;
        }
        public Point(int _X, int _Y):this(_X)
        {
            Y = _Y;
        }
        public Point(int _X , int _Y , int _Z):this(_X,_Y)
        {
            Z = _Z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }

        public int CompareTo(object? obj)
        {
            Point PassedPoint = (Point) obj;
            if (this.X > PassedPoint.X)
               return CompareY(this.Y,PassedPoint.Y);
            else if (this.X < PassedPoint.X)
               return CompareY(this.Y, PassedPoint.Y);
            else
               return CompareY(this.Y , PassedPoint.Y);
        }

        private int CompareY(int thisY , int PassedY)
        {
            if (thisY > PassedY)
                return 1;
            else if (thisY < PassedY)
                return -1;
            else
                return 0;
        }

        public object Clone()
        {
            return new Point(this);
        }
    }
}
