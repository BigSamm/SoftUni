using System;
using System.Collections.Generic;

public class Student
{
    private string name;
    private int age;
    private double grade;

    public double Grade
    {
        get { return grade; }
        set { grade = value; }
    }

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public Student(string name, int age, double grade)
    {
        this.Name = name;
        this.Age = age;
        this.grade = grade;
    }

    public override string ToString()
    {
        string view = $"{Name} is {Age} years old.";
        
        if (Grade >= 5.00)
            view += " Excellent student.";
        else if (Grade < 5.00 && Grade >= 3.50)
            view += " Average student.";
        else
            view += " Very nice person.";

        return view;
    }
}