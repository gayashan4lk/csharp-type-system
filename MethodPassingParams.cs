using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class MethodPassingParams
    {
        static void MethodPassing(string[] args)
        {
            int numberOfMonths = 12;
            int bonus = 5000;
            Console.WriteLine(CalcSal(2500, numberOfMonths, bonus));
            Console.WriteLine(bonus);
            Console.WriteLine(CalcSal(2456.45543, ref bonus));
            Console.WriteLine(bonus);
        }

        public static int CalcSal(int monthlySal, int numberOfMonths, int bonus)
        {
            if (monthlySal < 2000)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled.");
            }
            return monthlySal * numberOfMonths + bonus;
        }

        public static double CalcSal(double monthlySal, ref int bonus)
        {
            if (monthlySal < 3000)
            {
                bonus *= 3;
                Console.WriteLine("Bonus trippled");
            }
            double result = monthlySal * bonus;
            return result;
        }
    }
}
