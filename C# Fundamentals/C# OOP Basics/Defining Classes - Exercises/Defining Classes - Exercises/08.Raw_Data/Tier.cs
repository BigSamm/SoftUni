using System;
using System.Collections.Generic;
using System.Text;

public class Tier
{
    public double TierPressure { get; set; }
    public int TierAge { get; set; }

    public Tier(string pressureStr, string ageStr)
    {
        TierPressure = double.Parse(pressureStr);
        TierAge = int.Parse(ageStr);
    }
}
