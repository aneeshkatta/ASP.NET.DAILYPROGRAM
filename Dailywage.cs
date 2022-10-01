using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeswitchcase
{
    public class Dailywage
    {
        public static void Dailywage1()
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program ");
            int empHrs = 0;
                const int EMP_RATE_PER_HOUR = 20;
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == 0)
                {
                    Console.WriteLine("Employee wage is fulltime");
                    empHrs = 8;
                }
                else
                {
                    Console.WriteLine("Employee wage is parttime");
                    empHrs = 4;
                }
                int empWage = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Employee wage is " + empWage);
            
        }
    }
}

