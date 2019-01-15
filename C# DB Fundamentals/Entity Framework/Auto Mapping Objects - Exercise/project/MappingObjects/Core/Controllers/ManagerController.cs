namespace MappingObjects.App.Core.Controllers
{
    using System;
    using System.Linq;
    using AutoMapper.QueryableExtensions;

    using Contracts;
    using Data;
    using Data.Models;
    using Dtos;

    public class ManagerController : IManagerController
    {
        private readonly MappingObjectsDbContext context;

        public ManagerController(MappingObjectsDbContext context)
        {
            this.context = context;
        }

        public ManagerDto GetManagerInfo(int managerId)
        {
            ManagerDto manager = this.context.Employees
                .Where(e => e.EmployeeId == managerId)
                .ProjectTo<ManagerDto>()
                .SingleOrDefault();

            if (manager == null)
                throw new ArgumentException("Invalid Id!");

            return manager;
        }

        public void SetManager(int employeeId, int managerId)
        {
            Employee employee = this.context.Employees.Find(employeeId);
            Employee manager = this.context.Employees.Find(managerId);

            if (employee == null || manager == null)
                throw new ArgumentException("Invalid Id!");

            employee.Manager = manager;

            this.context.SaveChanges();
        }
    }
}
