using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeswitchcase
{
    public class EmployeepartTorfullT
    {
        public static void Empcheck()
        {
                Console.WriteLine("Welcome to Employee Wage Computation Program ");
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == 0)
                {
                    Console.WriteLine("Employee is fulltime");
                }
                else
                {
                    Console.WriteLine("Employee is parttime");
                }
            

        }
    }
}
