using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("**************************\n  Bethany's Pie Shop HRM\n**************************");

            if(Console.ForegroundColor != ConsoleColor.Black)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine("Select an action\n1. Register Employee\n2.Register work hours for employee\n3.Pay employee\n9.Exit");

            string userInput = Console.ReadLine();

            do
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Selected Register Emp");
                        break;

                    case "2":
                        Console.WriteLine("Selected Register work hours");
                        break;

                    case "3":
                        Console.WriteLine("Selected pay emp");
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            userInput = Console.ReadLine();
            }
            while (userInput != "9");

            Console.Clear();
            Environment.Exit(-1);





            /*Employee bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", 25, new DateTime(1992, 5, 15), EmployeeType.Manager);

            *//* bethany.firstName = "John";
             bethany.hourlyRate = 10;*//*
            //Employee notPossibleEmployee = new Employee(); // Default constructor is not exist.

            *//*// Objects are reference type.
            Employee testEmployee = bethany;
            testEmployee.firstName = "Gill";
            testEmployee.DisplayEmployeeDetails();*//*

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();

            Employee george = new Employee("George", "Jones", "george@gmail.com", 30, new DateTime(2000, 9, 15), EmployeeType.Research);

            george.DisplayEmployeeDetails();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.PerformWork();
            george.ReceiveWage();*/
        }
    }
}
