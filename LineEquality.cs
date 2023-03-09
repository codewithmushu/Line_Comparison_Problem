using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
     public class LineEquality
    {
        public static void CalcEqualityofLine()
        {
            Console.WriteLine("Please provide the (x,y) co-ordinates of the first end point of Line1 : ");
            double x1_1 = Convert.ToInt32(Console.ReadLine());
            double y1_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the (x,y) co-ordinates of the second end point of Line1 : ");
            double x2_1 = Convert.ToInt32(Console.ReadLine());
            double y2_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the (x,y) co-ordinates of the first end point of Line2 : ");
            double x1_2 = Convert.ToInt32(Console.ReadLine());
            double y1_2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please provide the (x,y) co-ordinates of the second end point of Line2 : ");
            double x2_2 = Convert.ToInt32(Console.ReadLine());
            double y2_2 = Convert.ToInt32(Console.ReadLine());

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
