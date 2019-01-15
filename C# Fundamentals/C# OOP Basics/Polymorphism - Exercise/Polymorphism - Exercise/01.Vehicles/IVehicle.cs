using System;
using System.Collections.Generic;
using System.Text;

public interface IVehicle
{
    double Fuel { get; }
    double Expense { get; }
    double TankCapacity { get; }

    void Drive(double distance);

    void Refuel(double liters);
}