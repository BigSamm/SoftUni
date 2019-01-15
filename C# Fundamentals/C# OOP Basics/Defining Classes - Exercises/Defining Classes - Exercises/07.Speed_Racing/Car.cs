using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsump { get; set; }
    public int Distance { get; set; }

    public Car(string model, double fuelAmount, double fuelConsump, int distance = 0)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsump = fuelConsump;
        Distance = distance;
    }

    public bool CanMoveDistance(int km)
    {
        if (FuelAmount >= FuelConsump * km)
            return true;

        return false;
    }

    public void MoveDistance(int km)
    {
        FuelAmount -= FuelConsump * km;
        Distance += km;
    }

    public void PrintCar()
    {
        Console.WriteLine($"{Model} {FuelAmount:f2} {Distance}");
    }
}
