namespace MappingObjects.App.Core.Dtos
{
    using Data.Models;

    public class EmployeeOlderThanDto
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public decimal Salary { get; set; }

        public Employee Manager { get; set; }

        public override string ToString()
        {
            string manager = this.Manager == null ? "[no manager]" : this.Manager.FirstName;
            string result = $"{this.FirstName} {this.LastName} - ${this.Salary:f2} - Manager: {manager}";

            return result;
        }
    }
}
