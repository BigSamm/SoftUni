namespace MappingObjects.App.Core.Commands
{
    using Contracts;

    public class SetManagerCommand : IExecutable
    {
        private readonly IManagerController managerController;

        public SetManagerCommand(IManagerController managerController)
        {
            this.managerController = managerController;
        }

        public string Execute(string[] args)
        {
            int employeeId = int.Parse(args[0]);
            int managerId = int.Parse(args[1]);

            this.managerController.SetManager(employeeId, managerId);

            string result = $"Employee with Id {managerId} was set manager to employee with Id {employeeId}.";
            return result;
        }
    }
}
