using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person() { }

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Salary = salary;
    }

    public decimal Salary
    {
        get { return salary; }
        private set {
            if (value < 460)
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            salary = value;
        }
    }

    public int Age
    {
        get { return age; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            age = value;
        }
    }
    
    public string LastName
    {
        get { return lastName; }
        private set {
            ValidateNameLength(value, "Last");
            lastName = value;
        }
    }

    public string FirstName
    {
        get { return firstName; }
        private set {
            ValidateNameLength(value, "First");
            firstName = value;
        }
    }

    private void ValidateNameLength(string value, string output)
    {
        if (value.Length < 3)
            throw new ArgumentException($"{output} name cannot contain fewer than 3 symbols!");
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.age < 30)
            percentage /= 2;

        this.Salary += this.salary * percentage / 100;
    }
}
