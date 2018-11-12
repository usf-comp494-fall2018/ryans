using System;
using System.Collections.Generic;
using System.Text;
namespace HomeWork4
{
    class SalariedEmployee : Employee
    {
        public double AnnualSalary { get; set; }
        public new void WriteToConsole()
        {
            Console.WriteLine(EmployeeCode + " | " + FirstName + " " + LastName + ",Hired on: " + DateHired+" and has an annual salary of :"+ AnnualSalary);
        }
    }
}
