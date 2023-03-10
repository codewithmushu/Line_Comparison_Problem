using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Welcome to line comparison computation program.");

            LineLength.CalcLengthofLine();



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

            LineEquality.CalcEqualityofLine(x1_1, y1_1, x2_1, y2_1, x1_2, y1_2, x2_2, y2_2);
            LineComparison.ComparisonOfLine(x1_1, y1_1, x2_1, y2_1, x1_2, y1_2, x2_2, y2_2);
        }
    }
}
