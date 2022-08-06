using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineUC
{
    internal class UC2
    {
        public void EqualityOfLine()
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
            Console.WriteLine("lENGTH1= "+length1);
            Console.WriteLine("lENGTH2= "+length2);
            Console.WriteLine("Equality is " + length1.Equals(length2));
        }
    }
}
