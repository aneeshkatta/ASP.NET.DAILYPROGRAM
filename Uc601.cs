using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maxworkhrs
{
    public class Uc601
    {
        public static void Uc6()
        {
            int empHrs = 0;
            const int EMP_RATE_PER_HOUR = 100;
           for (int day = 1; day <= 20; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                
                if (empCheck == 1)
                {
                    empHrs = 8;
                }
                else
                {
                    empHrs = 4;
                }
                empHrs += empHrs ;
            }

            int monthlyempwage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee days in month is 20");
            Console.WriteLine("Employee total hours worked in a month  is " + empHrs);
            Console.WriteLine("Employee wage per hr is 100");
            Console.WriteLine("Employee wage is " + monthlyempwage);
        }

    }
}
