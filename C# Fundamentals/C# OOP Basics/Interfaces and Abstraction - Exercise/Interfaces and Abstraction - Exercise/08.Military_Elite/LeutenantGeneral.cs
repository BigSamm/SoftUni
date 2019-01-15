using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    public LeutenantGeneral(string id, string firstName, string lastName, decimal salary, List<Private> privates)
        : base(id, firstName, lastName, salary)
    {
        this.Privates = privates;
    }

    public List<Private> Privates { get; private set; }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
        result.AppendLine("Privates:");
        this.Privates.ForEach(p => result.AppendLine("  " + p));

        return result.ToString().Trim();
    }
}