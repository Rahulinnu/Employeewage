using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWage
{
    public class UC5
    {
        public UC5()
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");

            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int WAGE_PER_HOUR = 20;
            const int MAX_WORKING_DAYS = 20;
            int totalMonthWage = 0;
            int empWorkHour = 0;
            int empDailyWage = 0;
            Random random = new Random();
            for (int day = 1; day <= MAX_WORKING_DAYS; day++)
            {
                int check = random.Next(0, 3);
                switch (check)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Present for Full Time");
                        empWorkHour = 8;
                        break;

                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Present for Part Time");
                        empWorkHour = 4;
                        break;

                    default:
                        Console.WriteLine("Employee is Absent");
                        empWorkHour = 0;
                        break;
                }

                empDailyWage = empWorkHour * WAGE_PER_HOUR;
                Console.WriteLine($"Employee Daily Wage for Day {day} : {empDailyWage}\n");
                totalMonthWage += empDailyWage;
            }
            Console.WriteLine($"\nEmployee Total Month Wage : {totalMonthWage}\n");
            Console.ReadLine();
        }
    }
}
