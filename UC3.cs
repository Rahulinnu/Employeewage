using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpWage
{
    public class UC3
    {
        public UC3()
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");

            const int isFullTime = 1;
            const int isPartTime = 2;
            const int wagePerHour = 20;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random();
            int check = random.Next(0, 3);
            if (check == isFullTime)
            {
                Console.WriteLine("Employee is Present for Full Time");
                empWorkHour = 8;
            }
            else if (check == isPartTime)
            {
                Console.WriteLine("Employee is Present for Part Time");
                empWorkHour = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empWorkHour = 0;
            }
            empDailyWage = empWorkHour * wagePerHour;
            Console.WriteLine($"\nEmployee Daily Wage : {empDailyWage}\n");
            Console.ReadLine();
        }
    }
}
