namespace MappingObjects.App.Core.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using AutoMapper.QueryableExtensions;

    using Contracts;
    using Data;
    using Data.Models;
    using Dtos;

    public class EmployeeController : IEmployeeController
    {
        private readonly MappingObjectsDbContext context;
        private readonly IMapper mapper;

        public EmployeeController(MappingObjectsDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public void AddEmployee(EmployeeDto employeeDto)
        {
            Employee employee = this.mapper.Map<Employee>(employeeDto);

            this.context.Employees.Add(employee);

            this.context.SaveChanges();
        }

        public EmployeeDto GetEmployeeInfo(int employeeId)
        {
            EmployeeDto employee = this.context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .ProjectTo<EmployeeDto>()
                .SingleOrDefault();

            if (employee == null)
                throw new ArgumentException("Invalid Id!");

            return employee;
        }

        public EmployeePersonalInfoDto GetEmployeePersonalInfo(int employeeId)
        {
            EmployeePersonalInfoDto employee = this.context.Employees
                .Where(e => e.EmployeeId == employeeId)
                .ProjectTo<EmployeePersonalInfoDto>()
                .SingleOrDefault();

            if (employee == null)
                throw new ArgumentException("Invalid Id!");

            return employee;
        }

        public void SetAddress(int employeeId, string address)
        {
            Employee employee = this.context.Employees.Find(employeeId);

            if (employee == null)
                throw new ArgumentException("Invalid Id!");

            employee.Address = address;

            this.context.SaveChanges();
        }

        public void SetBirthday(int employeeId, DateTime date)
        {
            Employee employee = this.context.Employees.Find(employeeId);

            if (employee == null)
                throw new ArgumentException("Invalid Id!");

            employee.Birthday = date;

            this.context.SaveChanges();
        }

        public List<EmployeeOlderThanDto> GetEmployeesOlderThan(int age)
        {
            List<EmployeeOlderThanDto> employees = this.context.Employees
                .Where(e => DateTime.Now.Year - e.Birthday.Value.Year > age)
                .ProjectTo<EmployeeOlderThanDto>()
                .ToList();

            return employees;
        }
    }
}
