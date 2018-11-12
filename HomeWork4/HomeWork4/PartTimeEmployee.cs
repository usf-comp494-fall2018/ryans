using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public new void WriteToConsole()
        {
            Console.WriteLine(EmployeeCode + " | " + FirstName + " " + LastName + ",Hired on: " + DateHired + " and has a hourly wage of :" + HourlyRate);
        }
    }
}
