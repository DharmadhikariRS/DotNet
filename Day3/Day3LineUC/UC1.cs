using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3LineUC
{
    internal class UC1
    {
        public void LineLengthCalc()
        {
            double x1, y1, x2, y2;
            Console.WriteLine("Enter 4 end points of line ");
            x1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());


            double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("Length of line is= " + length);
        }
    }
}
