using System;
using System.Collections.Generic;
using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public Student() { }

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            var minLength = 5;
            var maxLength = 10;
            ValidateFacultyNumber(value, minLength, maxLength);
            facultyNumber = value;
        }
    }

    private void ValidateFacultyNumber(string value, int minLength, int maxLength)
    {
        if (value.Length < minLength || value.Length > maxLength)
            throw new ArgumentException("Invalid faculty number!");

        for (int i = 0; i < value.Length; i++)
        {
            if (!Char.IsLetterOrDigit(value[i]))
                throw new ArgumentException("Invalid faculty number!");
        }
    }

    public override string ToString()
    {
        return base.ToString() +
            $"Faculty number: {FacultyNumber}\n";
    }
}
