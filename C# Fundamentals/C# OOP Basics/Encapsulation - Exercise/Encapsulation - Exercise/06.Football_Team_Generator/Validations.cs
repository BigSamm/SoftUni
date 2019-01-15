using System;
using System.Collections.Generic;
using System.Text;

public class Validations
{
    private const int MIN_STAT_VALUE = 0;
    private const int MAX_STAT_VALUE = 100;
    
    public static void ValidateStat(int value, string statName)
    {
        if (value < MIN_STAT_VALUE || value > MAX_STAT_VALUE)
            throw new ArgumentException($"{statName} should be between {MIN_STAT_VALUE} and {MAX_STAT_VALUE}.");
    }

    public static void ValidateName(string name)
    {
        if (String.IsNullOrWhiteSpace(name))
            throw new ArgumentException("A name should not be empty.");
    }

    public static void ValidateTeamExists(Dictionary<string, Team> teams, string teamName)
    {
        if (!teams.ContainsKey(teamName))
            throw new ArgumentException($"Team {teamName} does not exist.");
    }
}
