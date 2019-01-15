using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class RaceTower
{
    public int allLaps;
    public int currentLap;
    private int trackLength;
    public List<Driver> driversInRace;
    public Stack<Driver> driversOutOfRace;
    private string weather;

    public RaceTower()
    {
        this.driversInRace = new List<Driver>();
        this.driversOutOfRace = new Stack<Driver>();
        this.weather = "Sunny";
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
        this.allLaps = lapsNumber;
        this.trackLength = trackLength;
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        try
        {
            var driver = DriverFactory.CreateDriver(commandArgs);
            this.driversInRace.Add(driver);
        }
        catch (ArgumentExceptio)
        { }
    }

    public void DriverBoxes(List<string> commandArgs)
    {
        var reasonToBox = commandArgs[0];
        var driverName = commandArgs[1];
        var driverInBox = this.driversInRace.Find(d => d.Name == driverName);

        commandArgs = commandArgs.Skip(2).ToList();
        switch (reasonToBox)
        {
            case "ChangeTyres":
                driverInBox.GoBoxForTyreChange(commandArgs);
                break;
            case "Refuel":
                driverInBox.GoBoxForRefuel(commandArgs);
                break;
        }
    }

    public string CompleteLaps(List<string> commandArgs)
    {
        var numberOfLaps = int.Parse(commandArgs[0]);

        if (this.currentLap + numberOfLaps > this.allLaps)
            throw new ArgumentException($"There is no time! On lap {this.currentLap}." + Environment.NewLine);

        var result = new StringBuilder();
        for (int i = 0; i < numberOfLaps; i++)
        {
            for (int index = 0; index < this.driversInRace.Count; index++)
            {
                var driver = this.driversInRace[index];
                try
                {
                    driver.TryDoLap(this.trackLength);
                }
                catch (ArgumentException ex)
                {
                    GoOutOfRace(driver, ex.Message);
                    index--;
                }
            }

            this.currentLap++;

            var orderedDrivers = this.driversInRace.OrderByDescending(d => d.TotalTime).ToList();
            result.Append(TryOvertaking(orderedDrivers));
        }
        
        return result.ToString();
    }

    private void GoOutOfRace(Driver driver, string message)
    {
        this.driversInRace.Remove(driver);
        this.driversOutOfRace.Push(driver);
        driver.Fail(message);
    }

    private string TryOvertaking(List<Driver> orderedDrivers)
    {
        if (orderedDrivers.Count == 1)
            return string.Empty;

        var result = new StringBuilder();

        for (int index = 0; index < orderedDrivers.Count - 1; index++)
        {
            var driverBehind = orderedDrivers[index];
            var driverAhead = orderedDrivers[index + 1];

            var timeDiff = driverBehind.TotalTime - driverAhead.TotalTime;
            if (driverBehind is AggressiveDriver && driverBehind.Car.Tyre is UltrasoftTyre && timeDiff <= 3.0)
            {
                if (this.weather == "Foggy")
                {
                    GoOutOfRace(driverBehind, "Crashed");
                }
                else
                {
                    Overtake(result, driverBehind, driverAhead, index, 3, orderedDrivers);
                    index++;
                }
            }
            else if (driverBehind is EnduranceDriver && driverBehind.Car.Tyre is HardTyre && timeDiff <= 3.0)
            {
                if (this.weather == "Rainy")
                {
                    GoOutOfRace(driverBehind, "Crashed");
                }
                else
                {
                    Overtake(result, driverBehind, driverAhead, index, 3, orderedDrivers);
                    index++;
                }
            }
            else if (timeDiff <= 2.0)
            {
                Overtake(result, driverBehind, driverAhead, index, 2, orderedDrivers);
                index++;
            }
        }
        
        return result.ToString();
    }

    private void Overtake(StringBuilder result, Driver driverBehind, 
        Driver driverAhead, int index, int time, List<Driver> orderedDrivers)
    {
        driverBehind.Overtaking(time);
        driverAhead.Overtaken(time);

        orderedDrivers[index] = driverAhead;
        orderedDrivers[index + 1] = driverBehind;

        result.Append($"{driverBehind.Name} has overtaken {driverAhead.Name} on lap {this.currentLap}." + Environment.NewLine);
    }

    public string GetLeaderboard()
    {
        var result = new StringBuilder();
        result.Append($"Lap {this.currentLap}/{this.allLaps}" + Environment.NewLine);

        var allDrivers = this.driversInRace.OrderBy(d => d.TotalTime).ToList();
        allDrivers.AddRange(this.driversOutOfRace);

        for (int pos = 0; pos < allDrivers.Count; pos++)
        {
            var driver = allDrivers[pos];
            result.Append($"{pos + 1} ");
            result.Append(driver + Environment.NewLine);
        }

        return result.ToString();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        var weather = commandArgs[0];
        this.weather = weather;
    }
}