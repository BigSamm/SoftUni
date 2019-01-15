using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P12_Increase_Salaries
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            string[] allowableDepartments = new string[] { "Engineering", "Tool Design", "Marketing", "Information Services" };
            var employees = context.Employees
                .Where(e => allowableDepartments.Contains(e.Department.Name))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName);

            foreach (var employee in employees)
            {
                employee.Salary += employee.Salary * (decimal).12;
            }

            context.SaveChanges();

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
            }
        }
    }
}
