using System;
using System.Collections.Generic;
using System.Text;

public class Repair : IRepair
{
    public Repair(string name, int hoursWorked)
    {
        this.PartName = name;
        this.HoursWorked = hoursWorked;
    }

    public string PartName { get; private set; }
    public int HoursWorked { get; private set; }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}