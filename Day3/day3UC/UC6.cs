using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day3UC
{
    internal class UC6
    {
        int WagePerHr = 20;

        int empHrs = 0;
        int totalWorkingHrs = 0;

        int i = 0;
        public void EmpWageForMonthHr()
        {
            Console.WriteLine("UC2-Employee daily wage  fulltime parttime fo month max 100hr ");
            

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


            Console.WriteLine("Employee worked for {0} Days And worked for {1} hrs ", i - 1, totalWorkingHrs);
            Console.WriteLine("Monthly wage of employee is= " + totalWorkingHrs * WagePerHr);
        }
    }
}
