namespace MappingObjects.App.Core.Dtos
{
    using System.Collections.Generic;
    using System.Text;

    public class ManagerDto
    {
        public ManagerDto()
        {
            this.EmployeesDto = new List<EmployeeDto>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int EmployeesCount => this.EmployeesDto.Count;

        public ICollection<EmployeeDto> EmployeesDto { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"{this.FirstName} {this.LastName} | Employees: {this.EmployeesCount}");

            foreach (EmployeeDto employee in this.EmployeesDto)
            {
                result.AppendLine("\t- " + employee.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
