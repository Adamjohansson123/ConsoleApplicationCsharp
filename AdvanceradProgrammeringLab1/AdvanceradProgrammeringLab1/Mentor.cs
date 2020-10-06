using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceradProgrammeringLab1
{
    class Mentor : Employee
    {
        private List<Mentee> MenteeNameList;

        public Mentor(int PRNumber, string EmployeeName, string ProgrammingLanguage, string ProgrammingLevel, double BaseSalary) : base(PRNumber, EmployeeName, ProgrammingLanguage, ProgrammingLevel, BaseSalary)
        {
            this.PRNumber = PRNumber;
            this.EmployeeName = EmployeeName;
            this.ProgrammingLanguage = ProgrammingLanguage;
            this.ProgrammingLevel = ProgrammingLevel;
            this.BaseSalary = BaseSalary;
            MenteeNameList = new List<Mentee>();
        }

        public void AddMentee(Mentee mentee)
        {
            try
            {
                MenteeNameList.Add(mentee);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public override string ToString()
        {
            string s = "\n\nPR-Number: " + PRNumber + "\nName: " + EmployeeName + "\nProgramming Language: " + ProgrammingLanguage + "\nLevel: " + ProgrammingLevel + "\nSalary: " + ExtraSalaryForMentor() + "\nList of mentees: ";
            foreach(var item in MenteeNameList)
            {
                s += item.EmployeeName + " ";
            }
            return s;
        }

        public double ExtraSalaryForMentor()
        {
            try
            {
                BaseSalary = ExtraSalary();
                for (int i = 0; i < MenteeNameList.Count; i++)
                {
                    BaseSalary = BaseSalary * 1.05;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            return BaseSalary;
        }
    }
}
