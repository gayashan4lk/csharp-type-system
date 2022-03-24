using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{    
    public class Employee
    {
        public string firstName;
        public string lastName;
        public string email;

        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthday;

        public EmployeeType employeeType;

        public Employee(string firstName, string lastName, string email, double hourlyRate, DateTime birthday, EmployeeType employeeType)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.hourlyRate = hourlyRate;
            this.birthday = birthday;
            this.employeeType = employeeType;
        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, EmployeeType employeeType) : this(firstName, lastName, email, 0, birthday, employeeType)
        {
        }

        public void PerformWork()
        {
            numberOfHoursWorked++;

            Console.WriteLine($"{firstName} {lastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{firstName} {lastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            wage = numberOfHoursWorked * hourlyRate;
            Console.WriteLine($"The wage for {numberOfHoursWorked} hours of work is {wage}");
            numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name : {firstName}\nLast name : {lastName}\nEmail : {email}\nBirthday : {birthday.ToShortDateString()}\nEmployee type : {employeeType}\n");
        }
    }
}
