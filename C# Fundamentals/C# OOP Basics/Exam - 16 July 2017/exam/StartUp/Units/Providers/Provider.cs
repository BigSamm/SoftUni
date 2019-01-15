using System;
using System.Collections.Generic;
using System.Text;

public abstract class Provider : Unit
{
    private const double MAX_ENERGY_OUTPUT = 10_000;
    private const string ERROR_MESSAGE = "Provider is not registered, because of it's {0}";


    private double energyOutput;

    protected Provider(string id, double energyOutput)
        : base(id)
    {
        this.EnergyOutput = energyOutput;
    }

    public double EnergyOutput
    {
        get { return energyOutput; }
        protected set
        {
            if (value < 0 || value > MAX_ENERGY_OUTPUT)
                throw new ArgumentException(String.Format(ERROR_MESSAGE, "EnergyOutput"));

            energyOutput = value;
        }
    }

    public override string ToString()
    {
        return $"{this.Type} Provider - {base.Id}" + Environment.NewLine +
               $"Energy Output: {this.EnergyOutput}";
    }
}