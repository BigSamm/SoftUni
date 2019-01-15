using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    public string Name { get; set; }
    public string Birthday { get; set; }
    public List<Person> Parents { get; set; }
    public List<Person> Children { get; set; }

    public Person()
    {
        Parents = new List<Person>();
        Children = new List<Person>();
    }

    public Person(string firstName, string lastName) : this()
    {
        Name = $"{firstName} {lastName}";
    }

    public Person(string birthday) : this()
    {
        Birthday = birthday;
    }

    public Person(string firstName, string lastName, string birthday) : this()
    {
        Name = $"{firstName} {lastName}";
        Birthday = birthday;
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"{Name} {Birthday}");

        result.AppendLine("Parents:");
        Parents.ForEach(p => result.AppendLine($"{p.Name} {p.Birthday}"));

        result.AppendLine("Children:");
        Children.ForEach(ch => result.AppendLine($"{ch.Name} {ch.Birthday}"));

        return result.ToString();
    }
}
