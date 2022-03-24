using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
{    
    public class Employee
    {
        private string firstName;
        private string lastName;
        private string email;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthday;

        public EmployeeType employeeType;

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get
            {
                return numberOfHoursWorked;
            }
            set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get
            {
                return wage;
            }
            set
            {
                if(value < 0)
                {
                    wage = 0;
                }
                else
                {
                    wage = value;
                }
            }
        }

        public double HourlyRate
        {
            get
            {
                return hourlyRate;
            }
            set
            {
                hourlyRate = value;
            }
        }

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }

        public EmployeeType EmployeeType
        {
            get
            {
                return employeeType;
            }
            set
            {
                employeeType = value;
            }
        }

        public Employee(string firstName, string lastName, string email, double hourlyRate, DateTime birthday, EmployeeType employeeType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            HourlyRate = hourlyRate;
            Birthday = birthday;
            EmployeeType = employeeType;
        }

        public Employee(string firstName, string lastName, string email, DateTime birthday, EmployeeType employeeType) : this(firstName, lastName, email, 0, birthday, employeeType)
        {
        }

        public void PerformWork()
        {
            NumberOfHoursWorked++;

            Console.WriteLine($"{FirstName} {LastName} is now working!");
        }

        public void StopWorking()
        {
            Console.WriteLine($"{FirstName} {LastName} has stopped working!");
        }

        public double ReceiveWage()
        {
            Wage = NumberOfHoursWorked * HourlyRate;
            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}");
            NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name : {FirstName}\nLast name : {LastName}\nEmail : {Email}\nBirthday : {Birthday.ToShortDateString()}\nEmployee type : {EmployeeType}\n");
        }
    }
}
