using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Empwage
    {
        public static void Dailywage()
        {
            int IS_FULL_TIME = 1;
            int WAGE_PER_HOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
                empHrs = 8;
            //else
            // empHrs = 0;
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Emp Wage: " + empWage);
            //Console.ReadKey();
        }
    }
}
