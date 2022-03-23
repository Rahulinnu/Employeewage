using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmpWage
{
    public class UC1
    {
        public UC1()
        {
            Console.WriteLine("Welcome to Employee Wage Compuatation Program\n");

            const int isPresent = 1;

            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == isPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            Console.ReadLine();
        }

    }
}
