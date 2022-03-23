using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");

            const int isFullTime = 1;
            const int isPartTime = 2;
            const int wagePerHour = 20;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            switch (check)
            {

                case isFullTime:
                    Console.WriteLine("Employee is Present for Full Time");
                    empWorkHour = 8;
                    break;

                case isPartTime:
                    Console.WriteLine("Employee is Present for Part Time");
                    empWorkHour = 4;
                    break;

                default:
                    Console.WriteLine("Employee is Absent");
                    empWorkHour = 0;
                    break;
            }

            empDailyWage = empWorkHour * wagePerHour;
            Console.WriteLine($"\nEmployee Daily Wage : {empDailyWage}\n");
            Console.ReadLine();
        }
    }
}
