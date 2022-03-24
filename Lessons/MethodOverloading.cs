using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class MethodOverloading
    {
        static void MethodOverLoadingMain(string[] args)
        {
            Console.WriteLine($"Robert's Yearly Salary is {CalculateYearlyWage(25000, 12, 50000)}");
            Console.WriteLine($"Jane's Yearly Salary is {CalculateYearlyWage(14000, 12)}");
            Console.WriteLine($"Amily's Yearly Salary is {CalculateYearlyWage(2563.0224, 12, 56585898.365)}");
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12)
                return monthlyWage * (numberOfMonthsWorked + 1);

            return monthlyWage * numberOfMonthsWorked;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            return monthlyWage * numberOfMonthsWorked * bonus;
        }

        public static double CalculateYearlyWage(double monthlyWage, int numberOfMonthsWorked, double bonus)
        {
            return monthlyWage * numberOfMonthsWorked * bonus;
        }
    }
}
