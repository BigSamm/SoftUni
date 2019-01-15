using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DriverFactory
{
    public static Driver CreateDriver(List<string> arguments)
    {
        var type = arguments[0];
        var name = arguments[1];

        var carArguments = arguments.Skip(2).ToList();
        var car = CarFactory.CreateCar(carArguments);

        switch (type)
        {
            case "Aggressive":
                return new AggressiveDriver(name, car);
            case "Endurance":
                return new EnduranceDriver(name, car);
            default:
                throw new ArgumentException();
        }
    }
}