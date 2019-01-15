namespace MappingObjects.App.Core.Commands
{
    using System.Collections.Generic;
    using System.Text;

    using Contracts;
    using Dtos;

    public class ListEmployeesOlderThanCommand : IExecutable
    {
        private readonly IEmployeeController employeeController;

        public ListEmployeesOlderThanCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int age = int.Parse(args[0]);
            List<EmployeeOlderThanDto> employees = this.employeeController.GetEmployeesOlderThan(age);

            var result = new StringBuilder();
            foreach (EmployeeOlderThanDto employee in employees)
            {
                result.AppendLine(employee.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
