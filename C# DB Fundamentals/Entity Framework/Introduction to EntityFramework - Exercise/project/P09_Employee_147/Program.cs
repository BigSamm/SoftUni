using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P09_Employee_147
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var employee = context.Employees.FirstOrDefault(e => e.EmployeeId == 147);
            Console.WriteLine(employee.FirstName + " " + employee.LastName + " - " + employee.JobTitle);

            var projects = context.EmployeesProjects
                .Where(ep => ep.Employee == employee)
                .OrderBy(ep => ep.Project.Name)
                .Select(ep => ep.Project.Name);
            Console.WriteLine(String.Join(Environment.NewLine, projects));
        }
    }
}
