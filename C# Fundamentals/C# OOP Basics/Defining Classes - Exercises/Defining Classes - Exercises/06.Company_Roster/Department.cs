using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Department
{
    private string name;
    private List<Employee> employees;
    private List<decimal> salaries;
    private decimal averageSalary = -1;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public decimal AverageSalary
    {
        get { return averageSalary; }
        set { averageSalary = value; }
    }

    public List<Employee> Employees
    {
        get { return employees; }
        set { employees = value; }
    }

    public List<decimal> Salaries
    {
        get { return salaries; }
        set { salaries = value; }
    }

    public Department()
    {
        this.employees = new List<Employee>();
        this.salaries = new List<decimal>();
    }

    public void GetAverageSalary()
    {
        var averageSalary = salaries.Average();

        this.AverageSalary = averageSalary;
    }
}