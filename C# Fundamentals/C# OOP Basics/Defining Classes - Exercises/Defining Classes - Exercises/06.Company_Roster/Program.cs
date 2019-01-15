using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var departments = new Dictionary<string, Department>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var inputList = Console.ReadLine().Split();

            var name = inputList[0];
            var salary = decimal.Parse(inputList[1]);
            var position = inputList[2];
            var departmentInput = inputList[3];
            var email = "n/a";
            var age = -1;

            if (inputList.Length == 5)
            {
                bool isAge = int.TryParse(inputList[4], out age);
                if (!isAge)
                {
                    email = inputList[4];
                    age = -1;
                }
            }
            else if (inputList.Length == 6)
            {
                email = inputList[4];
                age = int.Parse(inputList[5]);
            }

            var employee = new Employee(name, salary, position, departmentInput, email, age);

            if (departments.ContainsKey(departmentInput))
            {
                var department = departments[departmentInput];
                department.Employees.Add(employee);
                department.Salaries.Add(salary);
                department.GetAverageSalary();
            }
            else
            {
                var department = new Department();
                department.Employees.Add(employee);
                department.Salaries.Add(salary);
                department.GetAverageSalary();
                departments[departmentInput] = department;
            }
        }

        var maxSalaryDepartment = new Department();
        foreach (var dep in departments)
        {
            if (dep.Value.AverageSalary > maxSalaryDepartment.AverageSalary)
            {
                maxSalaryDepartment = dep.Value;
                maxSalaryDepartment.Name = dep.Key;
            }
        }

        Console.WriteLine($"Highest Average Salary: {maxSalaryDepartment.Name}");
        maxSalaryDepartment.Employees = maxSalaryDepartment.Employees.OrderByDescending(emp => emp.Salary).ToList();
        foreach (var employee in maxSalaryDepartment.Employees)
        {
            Console.WriteLine($"{employee.Name} {employee.Salary:f2} {employee.Email} {employee.Age}");
        }
    }
}