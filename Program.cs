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

            //Employee notPossibleEmployee = new Employee(); // Default constructor is not exist.

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();
        }
    }
}
