using System;
using System.Collections.Generic;

class Program
{
    public static Dictionary<string, Team> teams = new Dictionary<string, Team>();

    static void Main(string[] args)
    {
        string inputLine;
        while((inputLine = Console.ReadLine()) != "END")
        {
            var inputList = inputLine.Split(';');
            var command = inputList[0];

            switch (command)
            {
                case "Team": AddTeam(inputList); break;
                case "Add": AddPlayerInTeam(inputList); break;
                case "Remove": RemovePlayerFromTeam(inputList); break;
                case "Rating": PrintTeamRating(inputList); break;
            }
        }
    }

    private static void PrintTeamRating(string[] inputList)
    {
        var teamName = inputList[1];
        try
        {
            Validations.ValidateTeamExists(teams, teamName);
            var teamRating = teams[teamName].CalculateRating();
            Console.WriteLine($"{teamName} - {teamRating}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void RemovePlayerFromTeam(string[] inputList)
    {
        var teamName = inputList[1];

        try
        {
            Validations.ValidateTeamExists(teams, teamName);

            var playerName = inputList[2];
            teams[teamName].RemovePlayer(playerName);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void AddPlayerInTeam(string[] inputList)
    {
        var teamName = inputList[1];

        var playerName = inputList[2];
        var endurance = int.Parse(inputList[3]);
        var sprint = int.Parse(inputList[4]);
        var dribble = int.Parse(inputList[5]);
        var passing = int.Parse(inputList[6]);
        var shooting = int.Parse(inputList[7]);

        Player player = new Player();
        try
        {
            Validations.ValidateTeamExists(teams, teamName);

            player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
            teams[teamName].AddPlayer(player);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void AddTeam(string[] inputList)
    {
        var teamName = inputList[1];

        Team team = new Team();
        try
        {
            team = new Team(teamName);
            teams[teamName] = team;
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
