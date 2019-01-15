namespace MappingObjects.App.Core.Commands
{
    using Contracts;
    using Dtos;

    public class ManagerInfoCommand : IExecutable
    {
        private readonly IManagerController managerController;

        public ManagerInfoCommand(IManagerController managerController)
        {
            this.managerController = managerController;
        }

        public string Execute(string[] args)
        {
            int managerId = int.Parse(args[0]);

            ManagerDto manager = this.managerController.GetManagerInfo(managerId);

            string result = manager.ToString();
            return result;
        }
    }
}
