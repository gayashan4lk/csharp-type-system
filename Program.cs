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
            Employee bethany = new Employee("Bethany", "Smith", "bethany@gmail.com", 25, new DateTime(1992, 5, 15), EmployeeType.Manager);

            /* bethany.firstName = "John";
             bethany.hourlyRate = 10;*/
            //Employee notPossibleEmployee = new Employee(); // Default constructor is not exist.

            /*// Objects are reference type.
            Employee testEmployee = bethany;
            testEmployee.firstName = "Gill";
            testEmployee.DisplayEmployeeDetails();*/

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
            george.ReceiveWage();
        }
    }
}
