using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private decimal salary;

    public Person(string firstName, string lastName, int age, decimal salary)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Salary = salary;
    }

    public decimal Salary
    {
        get { return salary; }
        set { salary = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public void IncreaseSalary(decimal percentage)
    {
        if (this.age < 30)
            percentage /= 2;

        this.Salary += this.salary * percentage / 100;
    }

    public override string ToString()
    {
        return $"{firstName} {lastName} receives {salary:f2} leva.";
    }
}
