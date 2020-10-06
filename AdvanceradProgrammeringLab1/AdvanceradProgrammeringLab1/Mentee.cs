using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceradProgrammeringLab1
{
    class Mentee : Employee
    {
        private Mentor mentor;

        public Mentee(int PRNumber, string EmployeeName, string ProgrammingLanguage, string ProgrammingLevel, double BaseSalary, Mentor mentor) : base(PRNumber, EmployeeName, ProgrammingLanguage, ProgrammingLanguage, BaseSalary)
        {
            this.PRNumber = PRNumber;
            this.EmployeeName = EmployeeName;
            this.ProgrammingLanguage = ProgrammingLanguage;
            this.ProgrammingLevel = ProgrammingLevel;
            this.BaseSalary = BaseSalary;
            this.mentor = mentor;
            mentor.AddMentee(this);
        }

        public override string ToString()
        {
            string s = "\n\nPR-Number: " + PRNumber + "\nName: " + EmployeeName + "\nProgramming Language: " + ProgrammingLanguage + "\nLevel: " + ProgrammingLevel + "\nSalary: " + SalaryMentee() + "\nMentor: " + mentor.EmployeeName;

            return s;
        }


        public double SalaryMentee()
        {
            BaseSalary = ExtraSalary();

            return BaseSalary;
        }
    }
}
