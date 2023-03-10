using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
   public class LineComparison
    {
        public static void  ComparisonOfLine( double x1_1, double y1_1, double x2_1, double y2_1, double x1_2, double y1_2, double x2_2, double y2_2)
        {
            double length1 = Math.Sqrt(Math.Pow(x2_1 - x1_1,2) + Math.Pow(y2_1 - y1_1,2));
            double length2 = Math.Sqrt(Math.Pow (x2_2 - x1_2 , 2) + Math.Pow(y2_2 - y1_2 , 2));

            if (length1 == length2)
            {
                Console.WriteLine("The two lines are equal in length");
            }
            else if (length2 < length1)
            {
                Console.WriteLine("The first line is longer than the second line. ");
            }
            else { Console.WriteLine("The second line is longer than the fisrt line."); }
        }
    }
}
