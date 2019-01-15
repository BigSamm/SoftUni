using System;
using System.Collections.Generic;
using System.Text;

public class Car : IVehicle
{
    public Car(double fuel, double expense, double tankCapacity)
    {
        this.Expense = expense + 0.9;
        this.TankCapacity = tankCapacity;

        if (fuel <= this.TankCapacity)
            this.Fuel = fuel;
        else
            this.Fuel = 0;
    }

    public double Fuel { get; private set; }
    public double Expense { get; private set; }
    public double TankCapacity { get; private set; }

    public void Drive(double distance)
    {
        var currentExpense = distance * this.Expense;

        if (currentExpense > this.Fuel)
        {
            Console.WriteLine("Car needs refueling");
            return;
        }

        this.Fuel -= currentExpense;
        Console.WriteLine($"Car travelled {distance} km");
    }

    public void Refuel(double liters)
    {
        if (this.Fuel + liters > this.TankCapacity)
        {
            Console.WriteLine($"Cannot fit {liters} fuel in the tank");
            return;
        }

        if (liters <= 0)
        {
            Console.WriteLine("Fuel must be a positive number");
            return;
        }

        this.Fuel += liters;
    }
}