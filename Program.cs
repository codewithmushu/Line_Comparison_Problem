using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine(" Welcome to line comparison computation program.");

            ////LineLength.CalcLengthofLine();
            //LineEquality.CalcEqualityofLine();


            Point p1 = new Point(1, 1);
            Point p2 = new Point(4, 5);
            Point p3 = new Point(0, 0);
            Point p4 = new Point(3, 4);

            Line line1 = new Line(p1, p2);
            Line line2 = new Line(p3, p4);

            if (line1.Equals(line2))
            {
                Console.WriteLine("The two lines are equal.");
            }
            else
            {
                Console.WriteLine("The two lines are not equal.");
            }
            int result = line1.CompareTo(line2);
            if (result == 0)
            {
                Console.WriteLine("The two lines are equal in length.");
            }
            else if (result > 0)
            {
                Console.WriteLine("Line 1 is longer than Line 2.");
            }
            else
            {
                Console.WriteLine("Line 2 is longer than Line 1.");
            }

        }
    }
}
