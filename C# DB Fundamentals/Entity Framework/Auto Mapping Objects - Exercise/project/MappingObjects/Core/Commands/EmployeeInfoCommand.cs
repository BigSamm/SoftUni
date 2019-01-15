namespace MappingObjects.App.Core.Commands
{
    using Contracts;
    using Dtos;

    public class EmployeeInfoCommand : IExecutable
    {
        private readonly IEmployeeController employeeController;

        public EmployeeInfoCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);

            EmployeeDto employee = this.employeeController.GetEmployeeInfo(employeeId);

            string result = employee.ToString();
            return result;
        }
    }
}
