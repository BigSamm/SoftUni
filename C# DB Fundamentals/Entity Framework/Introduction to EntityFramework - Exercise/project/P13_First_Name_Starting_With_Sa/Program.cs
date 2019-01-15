using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P13_First_Name_Starting_With_Sa
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName);

            foreach (var e in employees)
            {
                Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
            }
        }
    }
}
