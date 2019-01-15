using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;
using System;
using System.Globalization;
using System.Linq;

namespace P07_Employees_and_Projects
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var employees = context.EmployeesProjects
                .Include(e => e.Employee)
                .Include(e => e.Employee.Manager)
                .Where(e => e.Project.StartDate.Year >= 2001 && e.Project.StartDate.Year <= 2003)
                .GroupBy(e => e.Employee)
                .Take(30);

            foreach (var em in employees)
            {
                var employee = em.Key;
                var manager = employee.Manager;
                Console.WriteLine($"{employee.FirstName} {employee.LastName} – Manager: {manager.FirstName} {manager.LastName}");

                var projects = context.EmployeesProjects
                    .Include(ep => ep.Project)
                    .Include(ep => ep.Employee)
                    .Where(ep => ep.Employee == employee)
                    .GroupBy(ep => ep.Project);

                foreach (var pr in projects)
                {
                    var project = pr.Key;
                    var startDate = project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);
                    var endDate = project.EndDate?.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) ?? "not finished";
                    Console.WriteLine($"--{project.Name} - {startDate} - {endDate}");
                }
            }
        }
    }
}