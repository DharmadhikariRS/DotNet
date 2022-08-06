using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3UC
{
    
    internal class UC5
    {
        int WagePerHr = 20;

        int empHrs = 0;
        int totalWorkingHrs = 0;

        int i = 0;
        public void EmpWageForMonth()
        {

            Console.WriteLine("UC5-Employee daily wage  fulltime parttime fo month ");
         

            while (i <= 20)
            {
                Random randomval = new Random();

                int empCheck = randomval.Next(3);



                switch (empCheck)
                {
                    case 1:
                        empHrs = 8;

                        break;

                    case 2:
                        empHrs = 4;

                        break;

                    default:
                        empHrs = 0;
                        break;
                }
                totalWorkingHrs = totalWorkingHrs + empHrs;
                i++;
            }
            Console.WriteLine("Monthly wage of employee is= " + totalWorkingHrs * WagePerHr);
        }
    }
}
