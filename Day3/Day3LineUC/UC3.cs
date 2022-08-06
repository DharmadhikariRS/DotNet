using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineUC
{
    internal class UC3
    {
        public void ComparisonOfLine()
        {
            double x1, y1, x2, y2, x21, y21, x22, y22;
            Console.WriteLine("Enter 4 end points of line1 ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter 4 end points of line2 ");

            x21 = double.Parse(Console.ReadLine());
            x22 = double.Parse(Console.ReadLine());
            y21 = double.Parse(Console.ReadLine());
            y22 = double.Parse(Console.ReadLine());


            double length1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            double length2 = Math.Sqrt(Math.Pow((x22 - x21), 2) + Math.Pow((y22 - y21), 2));
            Console.WriteLine("Length1= {0} and Length2= {1}", length1, length2);
            int comparison = length1.CompareTo(length2);

            if (comparison == 0)
            {
                Console.WriteLine("As comparison= {0} therefore Lines are Equal", comparison);

            }
            else if (comparison > 0)
            {
                Console.WriteLine("As comparison=  {0} is positive value therefore Line1 is greater than Line2 ", comparison);

            }
            else
            {
                Console.WriteLine("As comparison= {0} is Negative  value therefore Line2 is greater than Line1", comparison);
            }
        }
    }
}
