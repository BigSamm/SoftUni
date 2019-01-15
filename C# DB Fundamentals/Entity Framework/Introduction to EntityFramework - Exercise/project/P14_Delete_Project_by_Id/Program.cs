using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P14_Delete_Project_by_Id
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var project = context.Projects.Find(2);

            var employeesProjects = context.EmployeesProjects.Where(ep => ep.Project == project);
            foreach (var employeeProject in employeesProjects)
            {
                context.EmployeesProjects.Remove(employeeProject);
            }

            context.Projects.Remove(project);

            context.SaveChanges();

            var projects = context.Projects.Take(10).Select(p => p.Name);
            Console.WriteLine(String.Join(Environment.NewLine, projects));
        }
    }
}
