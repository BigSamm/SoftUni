using System;
using System.Collections.Generic;
using System.Text;

public abstract class Tyre
{
    private const double TYRE_INITIAL_DEGRADATION = 100;

    protected Tyre(string name, double hardness)
    {
        this.Name = name;
        this.Hardness = hardness;
        this.Degradation = TYRE_INITIAL_DEGRADATION;
    }

    public string Name { get; private set; }
    public double Hardness { get; private set; }
    public double Degradation { get; protected set; }

    public virtual void TryDoLap()
    {
        this.Degradation -= this.Hardness;

        if (this.Degradation < 0)
            throw new ArgumentException("Blown Tyre");
    }
}