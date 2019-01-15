using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P10_DepartmentsWithMoreThan5Employees
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var departments = context.Departments
                .Include(d => d.Manager)
                .Include(d => d.Employees)
                .Where(d => d.Employees.Count > 5)
                .OrderBy(d => d.Employees.Count)
                .ThenBy(d => d.Name);

            foreach (var d in departments)
            {
                Console.WriteLine($"{d.Name} – {d.Manager.FirstName} {d.Manager.LastName}");

                var employees = d.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName);
                foreach (var e in employees)
                {
                    Console.WriteLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
                }

                Console.WriteLine("----------");
            }
        }
    }
}
