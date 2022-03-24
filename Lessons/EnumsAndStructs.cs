using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Lessons
{
    internal class EnumsAndStructs
    {
        static void EnumAndStructsMain(string[] args)
        {
            //List<string> myListObject = new List<string>();

            UsingMyEnum();
            UsingMyStruct();
            var employeeValue = EmployeeType.Manager;
            Console.WriteLine(employeeValue);
        }

        private static void UsingMyStruct()
        {
            Employee employee;
            employee.Name = "Edward";
            employee.Wage = 2563;
            employee.Work();
        }

        struct Employee
        {
            public string Name;
            public int Wage;

            public void Work()
            {
                Console.WriteLine($"{Name} is now doing work!");
            }
        }

        private static void UsingMyEnum()
        {
            EmployeeType employeeType = EmployeeType.Manager;
            StoreType storeType = StoreType.Seating;
            int baseWage = 1000;

            CalculateWage(baseWage, employeeType, storeType);
        }

        private static void CalculateWage(int baseWage, EmployeeType employeeType, StoreType storeType)
        {
            int calculateWage = 0;

            if (employeeType == EmployeeType.Manager)
            {
                calculateWage = baseWage * 3;
            }
            else
            {
                calculateWage *= 2;
            }

            if (storeType == StoreType.FullPieRestaurant)
            {
                calculateWage += 500;
            }

            Console.WriteLine($"The calculated Wage : {calculateWage}");
        }

        enum EmployeeType
        {
            Sales, // 0
            Manager, // 1
            Research, // 2
            StoreManager // 3
        }

        enum StoreType
        {
            PieCorner = 10,
            Seating = 20,
            FullPieRestaurant = 100,
            Undefined = 99
        }
    }
}
