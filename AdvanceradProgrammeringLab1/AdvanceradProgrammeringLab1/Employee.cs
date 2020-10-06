using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AdvanceradProgrammeringLab1
{
    class Employee
    {
        public int PRNumber;
        public string EmployeeName;
        public string ProgrammingLanguage;
        public string ProgrammingLevel;
        public double BaseSalary;

        public Employee(int PRNumber, string EmployeeName, string ProgrammingLanguage, string ProgrammingLevel, double BaseSalary)
        {
           this.PRNumber = PRNumber;
           this.EmployeeName = EmployeeName;
           this.ProgrammingLanguage = ProgrammingLanguage;
           this.ProgrammingLevel = ProgrammingLevel;
           this.BaseSalary = BaseSalary;
        }

        public override string ToString()
        {       
             return "\nPR-Number: " + PRNumber + "\nName: " + EmployeeName + "\nProgramming Language: " + ProgrammingLanguage + "\nLevel: " + ProgrammingLevel + "\nSalary: " + BaseSalary;          
        }

        public double ExtraSalary()
        {
            if(ProgrammingLanguage == "C#")
            {
                BaseSalary *= 1.1;
            }
            return BaseSalary;
        }

    }
    
    
}
