using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        private static List<Employee> employees = new List<Employee>();

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************\n  Bethany's Pie Shop HRM\n**************************");
            MakeConsoleTextWhite();

            DisplayMenuInstructions();

            string userInput = Console.ReadLine();

            do
            {
                switch (userInput)
                {
                    case "1": RegisterEmployee();
                        break;

                    case "2": RegisterWork();
                        break;

                    case "3": PayEmployee();
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

                DisplayMenuInstructions();
                userInput = Console.ReadLine();
            }
            while (userInput != "9");

            Console.Clear();
            Environment.Exit(-1);
        }

        private static void DisplayMenuInstructions()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Select an action\n1. Register Employee\n2. Register work hours for employee\n3. Pay employee\n9. Exit");
            MakeConsoleTextWhite();
        }
        private static void MakeConsoleTextWhite()
        {
            if (Console.ForegroundColor != ConsoleColor.White)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        private static void RegisterEmployee()
        {
            Console.WriteLine("Creating an employee...");
            Console.WriteLine("Enter first name :");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name :");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the hourly rate in USD :");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);

            Employee employee = new Employee(firstName, lastName, rate);
            employees.Add(employee);

            Console.WriteLine("Success! Employee was registerd.\n");
        }

        private static void RegisterWork()
        {
            if(employees.Count > 0)
            {
                Console.WriteLine("Select an employee:");

                for (int i = 1; i <= employees.Count; i++)
                {
                    Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}\n");
                }

                int selection = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of hours worked :\n");
                int hours = int.Parse(Console.ReadLine());

                Employee selectedEmployee = employees[selection - 1];

                int numberOfHoursWorked = selectedEmployee.PerformWork(hours);

                Console.WriteLine($"Total number of worked hours of {selectedEmployee.FirstName} {selectedEmployee.LastName} : {numberOfHoursWorked}\n");
            }
            else
            {
                Console.WriteLine("There are no employees registered! Please register an employee.\n");
            }
            
        }

        public static void PayEmployee()
        {
            if (employees.Count > 0)
            {
                Console.WriteLine("Select an employee:\n");

                for (int i = 1; i <= employees.Count; i++)
                {
                    Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}\n");
                }

                int selection = int.Parse(Console.ReadLine());

                Employee selectedEmployee = employees[selection - 1];
                int hoursWorked;
                double receivedWage = selectedEmployee.ReceiveWage(out hoursWorked);

                Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of $ {receivedWage}. The total hours of worked is reset to {hoursWorked}.\n");

            }
            else
            {
                Console.WriteLine("There are no employees registered! Please register an employee.\n");
            }
        }
    }
}
