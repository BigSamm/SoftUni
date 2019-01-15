using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    private const double FUEL_TANK_MAX_CAPACITY = 160;

    public Car(int hp, double fuelAmount, Tyre tyre)
    {
        this.Hp = hp;
        this.FuelAmount = fuelAmount;
        this.Tyre = tyre;
    }

    public int Hp { get; private set; }
    public double FuelAmount { get; private set; }
    public Tyre Tyre { get; private set; }

    public void Refuel(double fuel)
    {
        this.FuelAmount += fuel;

        if (this.FuelAmount > FUEL_TANK_MAX_CAPACITY)
            this.FuelAmount = FUEL_TANK_MAX_CAPACITY;
    }

    public void TryDoLap(int trackLength, double fuelConsumptionPerKm)
    {
        this.FuelAmount -= trackLength * fuelConsumptionPerKm;

        if (this.FuelAmount < 0)
            throw new ArgumentException("Out of fuel");

        this.Tyre.TryDoLap();
    }

    public void ChangeTyre(List<string> arguments)
    {
        var newTyre = TyreFactory.CreateTyre(arguments);
        this.Tyre = newTyre;
    }
}