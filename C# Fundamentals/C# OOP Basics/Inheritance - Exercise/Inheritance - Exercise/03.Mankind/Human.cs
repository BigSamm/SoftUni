using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Human
{
    private string firstName;
    private string lastName;

    public Human() { }

    public Human(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            var minLength = 3;
            var type = "lastName";
            CheckFirstLetter(value, type);
            CheckLength(value, minLength, type);

            lastName = value;
        }
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            var minLength = 4;
            var type = "firstName";
            CheckFirstLetter(value, type);
            CheckLength(value, minLength, type);

            firstName = value;
        }
    }

    private void CheckLength(string value, int minLength, string type)
    {
        if (value.Length < minLength)
            throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {type}");
    }

    private static void CheckFirstLetter(string value, string type)
    {
        var firstLetter = value.First();
        if (!Char.IsUpper(firstLetter))
            throw new ArgumentException($"Expected upper case letter! Argument: {type}");
    }

    public override string ToString()
    {
        return $"First Name: {FirstName}\n" +
               $"Last Name: {LastName}\n";
    }
}
