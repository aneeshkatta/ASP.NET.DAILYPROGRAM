using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageCheck
{
    internal class Employeecheck
    {
         public static void Employeeattendence()
            {
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

