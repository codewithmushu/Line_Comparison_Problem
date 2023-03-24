using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Point other = (Point)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 23 + X.GetHashCode();
            hash = hash * 23 + Y.GetHashCode();
            return hash;
        }
    }

    class Line : IComparable<Line>
    {
     public Point Start { get; set; }
     public Point End { get; set; }

            public Line(Point start, Point end)
            {
                Start = start;
                End = end;
            }

            public double Length()
            {
                return Math.Sqrt(Math.Pow(End.X - Start.X, 2) + Math.Pow(End.Y - Start.Y, 2));
            }

            public int CompareTo(Line other)
            {
                return Length().CompareTo(other.Length());
            }

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                Line other = (Line)obj;
                return Start.Equals(other.Start) && End.Equals(other.End);
            }

            public override int GetHashCode()
            {
                int hash = 17;
                hash = hash * 23 + Start.GetHashCode();
                hash = hash * 23 + End.GetHashCode();
                return hash;
            }


    }
    
}

