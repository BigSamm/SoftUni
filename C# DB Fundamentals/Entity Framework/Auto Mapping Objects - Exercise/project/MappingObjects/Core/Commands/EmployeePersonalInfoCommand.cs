namespace MappingObjects.App.Core.Commands
{
    using Contracts;
    using Dtos;

    public class EmployeePersonalInfoCommand : IExecutable
    {
        private readonly IEmployeeController employeeController;

        public EmployeePersonalInfoCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);

            EmployeePersonalInfoDto employee = this.employeeController.GetEmployeePersonalInfo(employeeId);

            string result = employee.ToString();
            return result;
        }
    }
}
