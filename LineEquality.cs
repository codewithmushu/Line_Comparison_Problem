using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
     public class LineEquality
    {
        public static void CalcEqualityofLine(double x1_1, double y1_1, double x2_1, double y2_1, double x1_2, double y1_2, double x2_2, double y2_2)
        {
            

            if ((x1_1 == x1_2 &&  y1_1 == y1_2 && x2_1 == x2_2 && y2_1 == y2_2) ||
                    (x1_1 == x2_2 && y1_1 == y2_2 && x2_1 == x1_2 && y2_1 == y1_2))
            {
                Console.WriteLine("The two lines are Equal.");
            }
            else
            {
                Console.WriteLine("The two lines are not Equal.");
            }
        }
    }
}
