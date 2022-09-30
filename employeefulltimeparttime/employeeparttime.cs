using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeefulltimeparttime
{
    public class employeeparttime
    {
        public static void Dailywageparttime()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 20;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            if (empCheck == 0)
            {
                Console.WriteLine("Employee is fulltime");
                empHrs = 8;
            }

            if (empCheck == 1)
            {
                Console.WriteLine("Employee is parttime");
                empHrs = 8;
            }
            if (empCheck == 2)
            {
                Console.WriteLine("Employee is absent");
                empHrs = 0;
            }
            int empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is " + empWage);
        }
    }
}
