using System;
using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string fitstName, string lastName,
        decimal salary, string corps, List<Repair> repairs)
        : base(id, fitstName, lastName, salary, corps)
    {
        this.Repairs = repairs;
    }

    public List<Repair> Repairs { get; private set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
        result.AppendLine($"Corps: {this.Corps}");
        result.AppendLine("Repairs:");
        foreach (var repair in this.Repairs)
        {
            result.AppendLine("  " + repair);
        }

        return result.ToString().Trim();
    }
}