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

            UC1 usc1 = new UC1();
            usc1.UsCa1();

            UC2 usc2 = new UC2();
            usc2.UsCa2();

            UC3 usc3 = new UC3();
            usc3.UsCa3();

            UC4 usc4 = new UC4();
            usc4.UsCa4();

            UC5 usc5 = new UC5();
            usc5.UsCa5();

            UC6 usc6 = new UC6();
            usc6.UsCa6();

        }
    }
}
