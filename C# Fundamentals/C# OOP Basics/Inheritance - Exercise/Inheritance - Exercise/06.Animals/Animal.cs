using System;
using System.Collections.Generic;
using System.Text;

public class Animal : ISoundProducable
{
    private string name;
    private int age;
    private string gender;

    public Animal() { }

    public Animal(string name, int age, string gender, string type)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
        this.Type = type;
    }

    private string Type { get; set; }

    public string Gender
    {
        get { return gender; }
        private set
        {
            if (value != "Male" && value != "Female")
                ThrowException();
            gender = value;
        }
    } 

    public int Age
    {
        get { return age; }
        private set
        {
            if (value < 0)
                ThrowException();
            age = value;
        }
    }

    public string Name
    {
        get { return name; }
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
                ThrowException();
            name = value;
        }
    }
    
    private void ThrowException()
    {
        throw new ArgumentException("Invalid input!");
    }

    public string ISoundProducable()
    {
        switch (Type)
        {
            case "Dog": return "Woof!";
            case "Frog": return "Ribbit";
            case "Cat": return "Meow meow";
            case "Kittens": return "Meow";
            case "Tomcat": return "MEOW";
        }

        return string.Empty;
    }

    public override string ToString()
    {
        return $"{this.Type}\n" +
               $"{this.Name} {this.Age} {this.Gender}\n" +
               $"{this.ISoundProducable()}";
    }
}
