using System;
using System.Collections.Generic;
using System.Text;

public abstract class Driver
{
    protected Driver(string name, Car car)
    {
        this.Name = name;
        this.TotalTime = 0;
        this.Car = car;
        this.Speed = 0;

        this.IsFail = false;
        this.FailureReason = string.Empty;
    }

    public string Name { get; private set; }
    public double TotalTime { get; protected set; }
    public Car Car { get; private set; }
    public double FuelConsumptionPerKm { get; protected set; }
    public double Speed { get; protected set; }

    public bool IsFail { get; private set; }
    public string FailureReason { get; private set; }

    public void Fail(string failureReason)
    {
        this.IsFail = true;
        this.FailureReason = failureReason;
    }

    public virtual void TryDoLap(int trackLength)
    {
        this.Speed = (this.Car.Hp + this.Car.Tyre.Degradation) / this.Car.FuelAmount;

        this.TotalTime += 60 / (trackLength / this.Speed);

        this.Car.TryDoLap(trackLength, this.FuelConsumptionPerKm);
    }
    
    public void Overtaking(int time)
    {
        this.TotalTime -= time;
    }

    public void Overtaken(int time)
    {
        this.TotalTime += time;
    }

    public void GoBoxForTyreChange(List<string> arguments)
    {
        this.TotalTime += 20;

        this.Car.ChangeTyre(arguments);
    }

    public void GoBoxForRefuel(List<string> arguments)
    {
        this.TotalTime += 20;

        var fuel = double.Parse(arguments[0]);
        this.Car.Refuel(fuel);
    }

    public override string ToString()
    {
        if (this.IsFail == false)
            return $"{this.Name} {this.TotalTime:f3}";
        else
            return $"{this.Name} {this.FailureReason}";
    }
}