using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    private const int MIN_NAME_LENGTH = 3;
    private const int MIN_AGE = 0;

    private string name;
    private int age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    protected virtual int Age
    {
        get { return age; }
        set
        {
            if (value < MIN_AGE)
                throw new ArgumentException($"Age must be positive!");
            age = value;
        }
    }

    protected virtual string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 3)
                throw new ArgumentException($"Name's length should not be less than {MIN_NAME_LENGTH} symbols!");
            name = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.Append(String.Format($"Name: {name}, Age: {age}"));

        return stringBuilder.ToString();
    }

}
