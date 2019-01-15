namespace MappingObjects.App.Core.Commands
{
    using Contracts;

    public class SetAddressCommand : IExecutable
    {
        private readonly IEmployeeController employeeController;

        public SetAddressCommand(IEmployeeController employeeController)
        {
            this.employeeController = employeeController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            string address = args[1];

            this.employeeController.SetAddress(employeeId, address);

            string result = $"Address was set successfully on employee with Id {employeeId}.";
            return result;
        }
    }
}
