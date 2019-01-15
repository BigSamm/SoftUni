using System;

[AttributeUsage(AttributeTargets.Class)]
public class CustomAttribute : Attribute
{
    public CustomAttribute()
    {
        this.Author = "Pesho";
        this.Revision = 3;
        this.Description = "Used for C# OOP Advanced Course - Enumerations and Attributes.";
        this.Reviewers = new string[] { "Pesho", "Svetlio" };
    }

    public string Author { get; private set; }

    public int Revision { get; private set; }

    public string Description { get; private set; }

    public string[] Reviewers { get; set; }
}