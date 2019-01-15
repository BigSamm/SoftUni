using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Team
{
    private string name;
    private List<Person> firstTeam;
    private List<Person> reserveTeam;

    public Team(string name)
    {
        this.name = name;
        firstTeam = new List<Person>();
        reserveTeam = new List<Person>();
    }

    public IReadOnlyList<Person> ReserveTeam
    {
        get { return reserveTeam; }
    }

    public IReadOnlyList<Person> FirstTeam
    {
        get { return reserveTeam; }
    }

    public void AddPlayer(Person person)
    {
        if (person.Age < 40)
            firstTeam.Add(person);
        else
            reserveTeam.Add(person);
    }

    public override string ToString()
    {
        return $"First team has {firstTeam.Count} players.\n" +
               $"Reserve team has {reserveTeam.Count} players.";
    }
}
