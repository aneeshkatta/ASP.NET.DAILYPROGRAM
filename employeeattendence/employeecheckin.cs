using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeattendence
{
    internal class employeecheckin
    {
            public static void Main()
            {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            Random random = new Random();
                int empCheck = random.Next(0, 2);
                if (empCheck == 0)
                {
                    Console.WriteLine("Employee is prsent");
                }
                else
                {
                    Console.WriteLine("Employee is absent");
                }
            }
        }
    }


