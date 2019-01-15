using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split();
            var car = new Car();

            car.Model = input[0];
            car.Engine = GetEngine(input[1], input[2]);
            car.Cargo = GetCargo(input[3], input[4]);
            for (int j = 5; j <= 12; j += 2)
            {
                var tier = GetCurrentTier(input[j], input[j + 1]);
                car.AllTires.Add(tier);
            }

            cars.Add(car);
        }

        var result = GetResult(cars);

        foreach (var car in result)
        {
            Console.WriteLine(car.Model);
        }
    }

    private static List<Car> GetResult(List<Car> cars)
    {
        var result = new List<Car>();

        var command = Console.ReadLine();
        if (command == "fragile")
        {
            foreach (var car in cars)
            {
                var haveLessThanOnePressure = car.AllTires.Any(t => t.TierPressure < 1);
                if (car.Cargo.CargoType == "fragile" && haveLessThanOnePressure)
                    result.Add(car);
            }
        }
        else if (command == "flamable")
        {
            result = cars.Where(c => c.Cargo.CargoType == "flamable" && c.Engine.EnginePower > 250).ToList();
        }

        return result;
    }

    private static Tier GetCurrentTier(string pressureStr, string ageStr)
    {
        var tier = new Tier(pressureStr, ageStr);

        return tier;
    }

    private static Cargo GetCargo(string weightStr, string type)
    {
        var cargo = new Cargo(weightStr, type);

        return cargo;
    }

    private static Engine GetEngine(string speedStr, string powerStr)
    {
        var engine = new Engine(speedStr, powerStr);

        return engine;
    }
}
