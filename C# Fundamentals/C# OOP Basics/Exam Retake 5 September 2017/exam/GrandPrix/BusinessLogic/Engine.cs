using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    public void Run()
    {
        var raceTower = new RaceTower();

        var lapsNumber = int.Parse(Console.ReadLine());
        var trackLenth = int.Parse(Console.ReadLine());
        raceTower.SetTrackInfo(lapsNumber, trackLenth);

        while (raceTower.currentLap != raceTower.allLaps)
        {
            var args = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = args[0];
            args = args.Skip(1).ToList();

            try
            {
                switch (command)
                {
                    case "RegisterDriver":
                        raceTower.RegisterDriver(args);
                        break;
                    case "Leaderboard":
                        Console.Write(raceTower.GetLeaderboard());
                        break;
                    case "CompleteLaps":
                        Console.Write(raceTower.CompleteLaps(args));
                        break;
                    case "Box":
                        raceTower.DriverBoxes(args);
                        break;
                    case "ChangeWeather":
                        raceTower.ChangeWeather(args);
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.Write(ex.Message);
            }
        }

        var winner = raceTower.driversInRace.OrderBy(d => d.TotalTime).First();
        Console.WriteLine($"{winner.Name} wins the race for {winner.TotalTime:f3} seconds.");
    }
}