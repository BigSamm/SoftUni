using System;

public abstract class Harvester : IHarvester
{    
    //private double oreOutput;
    //private double energyRequirement;

    protected Harvester(int id, double oreOutput, double energyRequirement)
    {
        this.ID = id;
        this.OreOutput = oreOutput;
        this.EnergyRequirement = energyRequirement;
        this.Durability = Constants.InitialEntityDurability;
    }

    public int ID { get; }

    public double OreOutput { get; protected set; }

    public double EnergyRequirement { get; protected set; }

    public virtual double Durability { get; protected set; }

    public void Broke()
    {
        this.Durability -= Constants.DurabilityLoss;

        if (this.Durability < 0)
            throw new Exception();
    }

    public double Produce()
    {
        return this.OreOutput;
    }
}