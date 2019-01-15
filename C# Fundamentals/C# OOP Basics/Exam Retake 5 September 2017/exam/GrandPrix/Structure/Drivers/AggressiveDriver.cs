using System;
using System.Collections.Generic;
using System.Text;

public class AggressiveDriver : Driver
{
    public AggressiveDriver(string name, Car car) 
        : base(name, car)
    {
        base.FuelConsumptionPerKm = 2.7;
    }

    public override void TryDoLap(int trackLength)
    {
        base.Speed = ((base.Car.Hp + base.Car.Tyre.Degradation) / base.Car.FuelAmount) * 1.3;

        base.TotalTime += 60 / (trackLength / base.Speed);

        base.Car.TryDoLap(trackLength, base.FuelConsumptionPerKm);
    }
}