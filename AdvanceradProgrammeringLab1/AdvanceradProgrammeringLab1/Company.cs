using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AdvanceradProgrammeringLab1
{
    class Company
    {
        public List<Employee> EmployeeList;

        public Company()
        {
            EmployeeList = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            try
            {
                EmployeeList.Add(employee);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void PrintList()
        {
            foreach (var item in EmployeeList)
            {
                Console.WriteLine(item);
            }
        }

        public string TotalSalaryBill()
        {
            double Total = 0;
            foreach(var item in EmployeeList)
            {
               Total+= item.BaseSalary;
            }
            return "\nTotal salary bill for the company: " + Total;
        }
    }
}
