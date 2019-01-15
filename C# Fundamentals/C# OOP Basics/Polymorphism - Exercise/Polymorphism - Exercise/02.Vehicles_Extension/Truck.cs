using System;
using System.Collections.Generic;
using System.Text;

public class Truck : IVehicle
{
    public Truck(double fuel, double expense, double tankCapacity)
    {
        this.Expense = expense + 1.6;
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
            Console.WriteLine("Truck needs refueling");
            return;
        }

        this.Fuel -= currentExpense;
        Console.WriteLine($"Truck travelled {distance} km");
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

        this.Fuel += liters * 0.95;
    }
}