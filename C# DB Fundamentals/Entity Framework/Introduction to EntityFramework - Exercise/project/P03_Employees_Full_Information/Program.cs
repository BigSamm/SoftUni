using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;

namespace P03_Employees_Full_Information
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

             var employees = context.Employees;

            foreach (Employee e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
            }
        }
    }
}
