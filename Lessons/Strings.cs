using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Lessons
{
    internal class Strings
    {
        static void StringMain(string[] args)
        {
            string name = "Leonado";
            string emptyString = String.Empty;
            var someString = "MotherFucker";
            string nullString = null;
            string unsignedString;

            string firstName = "Albert";
            string lastName = "Einstaine";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);

            string theSciencetist = string.Concat(firstName, " ", lastName);
            Console.WriteLine(theSciencetist);

            string crazyName = firstName.ToLower() + " - " + lastName.ToUpper();
            Console.WriteLine(crazyName);

            string effectiveString = $"{fullName} {lastName}";
            Console.WriteLine(effectiveString);

            Console.WriteLine("Here are the employee details : \nBethany\tSmith");
            Console.WriteLine("File Path : C:\\data\\details.txt");
            Console.WriteLine("Baking the \"best pies\" ever");
            string verbateFilePath = @"C:\data\dtails.txt";
            Console.WriteLine(verbateFilePath);

            string str = "Maxwell";
            bool isEqual = str == "Maxwell";
            bool strResult = str == "maxwell";
            bool anotherResult = str.Equals("Maxwell");

            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("Employee list");
            strBuild.AppendLine("Bethany Smith");
            strBuild.AppendLine("George Jones");
            string list = strBuild.ToString();
            Console.WriteLine(list);

            string wageString = Console.ReadLine();
            double wageNumber = double.Parse(wageString);

            bool active = bool.Parse("true");

        }
    }
}
