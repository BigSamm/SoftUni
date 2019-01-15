using System;
using System.Collections.Generic;
using System.Text;

public class UltrasoftTyre : Tyre
{
    public UltrasoftTyre(double hardness, double grip) : base("Ultrasoft", hardness)
    {
        this.Grip = grip;
    }

    public double Grip { get; private set; }

    public override void TryDoLap()
    {
        base.Degradation -= base.Hardness + this.Grip;

        if (base.Degradation < 30)
            throw new ArgumentException("Blown Tyre");
    }
}