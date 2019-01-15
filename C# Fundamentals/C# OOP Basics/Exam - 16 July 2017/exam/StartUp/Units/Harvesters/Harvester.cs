using System;
using System.Collections.Generic;
using System.Text;

public abstract class Harvester : Unit
{
    private const double MAX_ENERGY_REQUIREMENT = 20_000;
    private const string ERROR_MESSAGE = "Harvester is not registered, because of it's {0}";


    private double oreOutput;
    private double energyRequirement;
    
    protected Harvester(string id, double oreOutput, double energyRequirement)
        : base(id)
    {
        this.ОreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
    }

    public double EnergyRequirement
    {
        get { return energyRequirement; }
        protected set
        {
            if (value < 0 || value > MAX_ENERGY_REQUIREMENT)
                throw new ArgumentException(String.Format(ERROR_MESSAGE, "EnergyRequirement"));

            energyRequirement = value;
        }
    }

    public double ОreOutput
    {
        get { return oreOutput; }
        protected set
        {
            if (value < 0)
                throw new ArgumentException(String.Format(ERROR_MESSAGE, "ОreOutput"));

            oreOutput = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Type} Harvester - {base.Id}" + Environment.NewLine +
               $"Ore Output: {this.ОreOutput}" + Environment.NewLine +
               $"Energy Requirement: {this.EnergyRequirement}";
    }
}