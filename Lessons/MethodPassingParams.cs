using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{
    internal class MethodPassingParams
    {
        static void MethodPassingMain(string[] args)
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

        static void ParamsAndExpressionBodiedSytax(string[] args)
        {
            int avr = CalcAvr(1, 2, 3, 6, 8, 10);
            Console.WriteLine(avr);

            Console.WriteLine($"MultiPlyied Number is : {MultiplyNumber(25, 3)}");

        }

        public static int CalcAvr(params int[] num)
        {
            int total = 0;

            for (int i = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            return total / num.Length;
        }

        // Expression-Bodied Syntax
        public static int MultiplyNumber(int number, int multiplier) => number * multiplier;
    }
}
