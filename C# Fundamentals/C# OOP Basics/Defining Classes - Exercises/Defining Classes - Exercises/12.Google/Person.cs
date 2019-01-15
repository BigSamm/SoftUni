using System;
using System.Collections.Generic;
using System.Text;

public class Person
{
    public string Name { get; set; }
    public Company Company { get; set; }
    public Car Car { get; set; }
    public List<Parent> Parents { get; set; }
    public List<Child> Children { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Person(string name)
    {
        Name = name;
        Company = new Company();
        Car = new Car();
        Parents = new List<Parent>();
        Children = new List<Child>();
        Pokemons = new List<Pokemon>();
    }

    public Person(string name, Company company, Car car, Parent parent, Child child, Pokemon pokemon)
    {
        Name = name;
        Company = company;
        Car = car;

        Parents = new List<Parent>();
        Parents.Add(parent);

        Children = new List<Child>();
        Children.Add(child);

        Pokemons = new List<Pokemon>();
        Pokemons.Add(pokemon);
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine(Name);

        result.AppendLine("Company:");
        if (Company.Name != "")
            result.Append(Company + "\n");

        result.AppendLine("Car:");
        if (Car.Model != "")
            result.Append(Car + "\n");


        result.AppendLine("Pokemon:");
        Pokemons.ForEach(p => result.Append(p + "\n"));

        result.AppendLine("Parents:");
        Parents.ForEach(p => result.Append(p + "\n"));

        result.AppendLine("Children:");
        Children.ForEach(ch => result.Append(ch + "\n"));

        return result.ToString();
    }
}
