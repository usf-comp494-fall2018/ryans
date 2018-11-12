using System;

namespace HomeWork4
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateHired { get; set; }
        public int EmployeeCode { get; set; }

        public void WriteToConsole()
        {
            Console.WriteLine(EmployeeCode + " | " + FirstName + " " + LastName + ",Hired on: " + DateHired);
        }

    }
}
