namespace MappingObjects.App.Core.Contracts
{
    using Dtos;

    public interface IManagerController
    {
        void SetManager(int employeeId, int managerId);

        ManagerDto GetManagerInfo(int managerId);
    }
}
