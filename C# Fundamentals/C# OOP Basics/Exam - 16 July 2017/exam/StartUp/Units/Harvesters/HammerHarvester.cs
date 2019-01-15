using System;
using System.Collections.Generic;
using System.Text;

public class HammerHarvester : Harvester
{
    public HammerHarvester(string id, double oreOutput, double energyRequirement) 
        : base(id, oreOutput, energyRequirement)
    {
        base.ОreOutput *= 3;
        base.EnergyRequirement *= 2;
    }

    public override string Type => "Hammer";
}