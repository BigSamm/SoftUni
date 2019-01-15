namespace MappingObjects.App.Core.Dtos
{
    using System;
    using System.Text;

    public class EmployeePersonalInfoDto
    {
        public int EmployeeId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public decimal Salary { get; set; }

        public DateTime? Birthday { get; set; }

        public string Address { get; set; }

        public override string ToString()
        {
            var result = new StringBuilder();

            result.AppendLine($"ID: {this.EmployeeId} - {this.FirstName} {this.LastName} - ${this.Salary:f2}");

            if (this.Birthday != null)
                result.AppendLine($"Birthday: {this.Birthday.Value.ToString("dd-MM-yyyy")}");

            if (this.Address != null)
                result.AppendLine($"Address: {this.Address}");

            return result.ToString().Trim();
        }
    }
}
