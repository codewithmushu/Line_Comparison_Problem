using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class LineLength
    {
        public static void CalcLengthofLine()
        {
            Console.WriteLine("Please enter the (x,y) co-ordinate of first point : ");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the (x,y) co-ordinates of second point : ");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            double Length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Lenth of the line is : " +  Length);
        }

    }
}
