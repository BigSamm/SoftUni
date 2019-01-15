using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Team
{
    private string name;
    private Dictionary<string, Player> Players { get; set; }

    public Team() { }

    public Team(string name)
    {
        Name = name;
        Players = new Dictionary<string, Player>();
    }

    public string Name
    {
        get { return name; }
        private set
        {
            Validations.ValidateName(value);
            name = value;
        }
    }

    public void AddPlayer(Player player)
    {
        Players[player.Name] = player;
    }

    public void RemovePlayer(string playerName)
    {
        if (Players.ContainsKey(playerName))
            Players.Remove(playerName);
        else
            throw new ArgumentException($"Player {playerName} is not in {Name} team.");
    }

    public double CalculateRating()
    {
        if (Players.Count == 0)
            return 0;

        double sumPlayersSkillsLevel = 0;
        foreach (var player in Players)
        {
            sumPlayersSkillsLevel += player.Value.SkillLevel;
        }

        return Math.Round(sumPlayersSkillsLevel / Players.Count);
    }
}
