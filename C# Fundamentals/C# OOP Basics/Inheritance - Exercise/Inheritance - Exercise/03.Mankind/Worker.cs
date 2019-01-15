using System;
using System.Collections.Generic;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private double workHoursPerDay;
    public decimal SalaryPerHour { get; set; }

    public Worker() { }

    public Worker(string firstName, string lastName, decimal weekSalary, double workHoursPerDay)
        :base(firstName, lastName)
    {
        WeekSalary = weekSalary;
        WorkHoursPerDay = workHoursPerDay;

        SalaryPerHour = CalculateSalaryPerHour();
    }

    public double WorkHoursPerDay
    {
        get { return workHoursPerDay; }
        set
        {
            var minWorkingHours = 1.0;
            var maxWorkingHours = 12.0;
            if (value < minWorkingHours || value > maxWorkingHours)
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            workHoursPerDay = value;
        }
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            var minWeekSalary = 10.0m;
            if (value <= minWeekSalary)
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            weekSalary = value;
        }
    }

    private decimal CalculateSalaryPerHour()
    {
        var workDays = 5;
        var daySalary = WeekSalary / workDays ;
        var salaryPerHour = daySalary / (decimal)WorkHoursPerDay;

        return salaryPerHour;
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Week Salary: {WeekSalary:f2}\n" +
            $"Hours per day: {WorkHoursPerDay:f2}\n" +
            $"Salary per hour: {SalaryPerHour:f2}";
    }
}
