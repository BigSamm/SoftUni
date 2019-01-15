using System;

public class Provider : IProvider
{
    protected Provider(int id, double energyOutput)
    {
        this.ID = id;
        this.EnergyOutput = energyOutput;
        this.Durability = Constants.InitialEntityDurability;
    }

    public double EnergyOutput { get; protected set; }

    public int ID { get; protected set; }

    public double Durability { get; protected set; }

    public void Broke()
    {
        this.Durability -= Constants.DurabilityLoss;

        if (this.Durability < 0)
            throw new Exception();
    }

    public double Produce()
    {
        return this.EnergyOutput;
    }

    public void Repair(double val)
    {
        this.Durability += val;
    }
}