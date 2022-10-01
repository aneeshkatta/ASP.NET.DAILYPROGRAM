using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeswitchcase

{
    public class program
    {
        private static readonly int empCheck;

        public static void Main(string[] args)
        {
            //Console.WriteLine("enter a) A value one to check employee attendence b) A value two to check employee part time or full time worker c) A value three to check employee salary" + EmpCheck);
            //Random random = new Random();
            //int EmpCheck = random.Next(0, 3); 
            //int EmpCheck;

            Console.WriteLine("Enter Number\n 1.To check Employe Present/absent\t 2.To check Employee is partTime or fullTime\t 3. To check Employee daily wage");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Empswitchcase.Main1();
                    break;

                case 2:
                    EmployeepartTorfullT.Empcheck();
                    break;
                case 3:
                    Dailywage.Dailywage1();
                    break;
                default:
                    break;

            }
         }

    }
 }
