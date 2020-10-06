using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using Lab1Library; //DLL
using System.Xml.Serialization;

namespace AdvanceradProgrammeringLab1
{
    class Program
    {
        public delegate string WelcomeEmployee(string EmpName); //Delegate
        public static Company myCompany = new Company();
        public static double EmpSalary = 30000;
        static void Main(string[] args)
        {
           //Jag har använt mig av en listor (Collections) då det är smidigt att använda sig av när man har flera olika klasser inom ett projekt och är enkelt att lagra värden inuti.

           string CompanyName = "University West";
           string userInput;

           ICompany.CompanyName(CompanyName); //DLL

           Console.WriteLine("\nWhat´s your name?");
           userInput = Console.ReadLine();

           WelcomeEmployee obj = new WelcomeEmployee(Welcome); //Delegate

           string WelcomeMessage = obj(userInput); //Delegate
           Console.WriteLine(WelcomeMessage); //Delegate

           Console.WriteLine("\nLIST OF ALL EMPLOYEES");
           
           Mentor mentor = new Mentor(1, "Abdulghafour", "C#", "Senior", EmpSalary);
           Mentor mentor1 = new Mentor(2, "Jan-Olof", "C#", "Senior", EmpSalary);

           Mentee mentee = new Mentee(3, "Adam", "C#", "Junior", EmpSalary, mentor);
           Mentee mentee2 = new Mentee(4, "Alfred", "C#", "Junior", EmpSalary, mentor);
           Mentee mentee3 = new Mentee(5, "Patrik", "C#", "Junior", EmpSalary, mentor1);

           try
           {
               myCompany.AddEmployee(mentor);
               myCompany.AddEmployee(mentor1);

               myCompany.AddEmployee(mentee);
               myCompany.AddEmployee(mentee2);
               myCompany.AddEmployee(mentee3);
           }
           catch(Exception e)
           {
               Console.WriteLine(e.Message);
           }

           myCompany.PrintList();

           Console.WriteLine(myCompany.TotalSalaryBill());

        }

        public static string Welcome(string Name) //Delegate
        {
            return "\nWelcome " + Name + "!";
        }

    }
}
 