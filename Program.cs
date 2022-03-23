using System;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 123;
            int months = 12, bonus = 1000;
            bool isActive = true;
            double rating = 99.9;
            double ratePerHour = 12.34;
            int numberOfHoursWorked = 165;

            double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;

            Console.WriteLine(currentMonthWage);

            ratePerHour += 3; // ratePerHour = ratePerHour + 3;

            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee");
            }

            int numberOfEmployees = 15;
            numberOfEmployees--;

            bool a; // Default assigned value = false
            int b;  // Default assigned value = 0

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);
            Console.WriteLine($"You entered {number}");

            int intMaxValue = int.MaxValue;
            int intMinValue = int.MinValue;

            char userSelection = 'a';
            char upperVersion = char.ToUpper(userSelection);
            bool isDigit = char.IsDigit(userSelection);
            bool isLetter = char.IsLetter(userSelection);


        }
    }
}
