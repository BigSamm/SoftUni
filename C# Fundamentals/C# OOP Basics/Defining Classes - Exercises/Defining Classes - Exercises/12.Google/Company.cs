using System;
using System.Collections.Generic;
using System.Text;

public class Company
{
    public string Name { get; set; }
    public string Department { get; set; }
    public decimal Salary { get; set; }

    public Company()
    {
        Name = "";
    }

    public Company(string name, string department, string salaryStr)
    {
        Name = name;
        Department = department;
        Salary = decimal.Parse(salaryStr);
    }

    public override string ToString()
    {
        return $"{Name} {Department} {Salary:f2}";
    }
}
