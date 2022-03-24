using System;
using System.Text;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int avr = CalcAvr(1, 2, 3, 6, 8, 10);
            Console.WriteLine(avr);
        
            Console.WriteLine($"MultiPlyied Number is : {MultiplyNumber(25, 3)}");

        }

        public static int CalcAvr(params int[] num)
        {
            int total = 0;

            for(int i = 0; i < num.Length; i++)
            {
                total += num[i];
            }
            return total / num.Length;
        }

        // Expression-Bodied Syntax
        public static int MultiplyNumber(int number, int multiplier) => number * multiplier;
    }
}
