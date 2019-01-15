using System;
using System.Collections.Generic;
using System.Text;

public class Footman : IUnit
{
    private int hitsCounter;

    public Footman(string name)
    {
        this.Name = name;
        this.hitsCounter = 0;
    }

    public string Name { get; private set; }

    public bool IsAlive => this.hitsCounter == 2 ? false : true;

    public void IsHitten()
    {
        this.hitsCounter++;
    }

    public string RespondAttack()
    {
        var result = $"Footman {this.Name} is panicking!";
        return result;
    }
}