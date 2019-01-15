using System;
using System.Collections.Generic;
using System.Text;

public class Player
{
    private string name;
    private int endurance;
    private int sprint;
    private int dribble;
    private int passing;
    private int shooting;
    public double SkillLevel { get; private set; }

    public Player() { }

    public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
    {
        Name = name;
        Endurance = endurance;
        Sprint = sprint;
        Dribble = dribble;
        Passing = passing;
        Shooting = shooting;

        SkillLevel = CalculatePlayerSkillLevel();
    }

    public int Shooting
    {
        get { return shooting; }
        private set
        {
            Validations.ValidateStat(value, "Shooting");
            shooting = value;
        }
    }

    public int Passing
    {
        get { return passing; }
        private set
        {
            Validations.ValidateStat(value, "Passing");
            passing = value;
        }
    }

    public int Dribble
    {
        get { return dribble; }
        private set
        {
            Validations.ValidateStat(value, "Dribble");
            dribble = value;
        }
    }

    public int Sprint
    {
        get { return sprint; }
        private set
        {
            Validations.ValidateStat(value, "Sprint");
            sprint = value;
        }
    }

    public int Endurance
    {
        get { return endurance; }
        private set
        {
            Validations.ValidateStat(value, "Endurance");
            endurance = value;
        }
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

    private double CalculatePlayerSkillLevel()
    {
        return (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
    }
}
