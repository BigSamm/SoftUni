using System;
using System.Collections.Generic;
using System.Text;

public class RoyalGuard : IUnit
{
    private int hitsCounter;

    public RoyalGuard(string name)
    {
        this.Name = name;
        this.hitsCounter = 0;
    }

    public string Name { get; private set; }

    public bool IsAlive => this.hitsCounter == 3 ? false : true;

    public void IsHitten()
    {
        hitsCounter++;
    }

    public string RespondAttack()
    {
        var result = $"Royal Guard {this.Name} is defending!";
        return result;
    }
}