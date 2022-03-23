using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpWage
{
    public class UC2
    {
        public UC2()
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");

            const int isPresent = 1;
            const int wagePerHour = 20;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empWorkHour = 8;
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
