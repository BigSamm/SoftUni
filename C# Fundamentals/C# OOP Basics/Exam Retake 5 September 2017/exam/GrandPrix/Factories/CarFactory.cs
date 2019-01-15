using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarFactory
{
    public static Car CreateCar(List<string> arguments)
    {
        var hp = int.Parse(arguments[0]);
        var fuelAmount = double.Parse(arguments[1]);

        var tyreArguments = arguments.Skip(2).ToList();
        var tyre = TyreFactory.CreateTyre(tyreArguments);

        return new Car(hp, fuelAmount, tyre);
    }
}