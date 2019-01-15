using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Engine> engines = GetAllEngines();

        List<Car> cars = GetAllCars(engines);

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }

    private static List<Car> GetAllCars(List<Engine> engines)
    {
        var cars = new List<Car>();

        var carsCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < carsCount; i++)
        {
            var inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var model = inputList[0];
            var engineModel = inputList[1];
            var engine = engines.Find(e => e.Model == engineModel);

            var weight = "n/a";
            var color = "n/a";

            if (inputList.Length == 3)
            {
                int justForCheck;
                bool isWeight = int.TryParse(inputList[2], out justForCheck);

                if (isWeight)
                    weight = inputList[2];
                else
                    color = inputList[2];
            }
            else if (inputList.Length == 4)
            {
                weight = inputList[2];
                color = inputList[3];
            }

            var car = new Car(model, engine, weight, color);
            cars.Add(car);
        }

        return cars;
    }

    private static List<Engine> GetAllEngines()
    {
        var engines = new List<Engine>();

        var enginesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < enginesCount; i++)
        {
            var inputList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var model = inputList[0];
            var powerStr = inputList[1];
            var displacement = "n/a";
            var efficiency = "n/a";

            if (inputList.Length == 3)
            {
                int justForCheck;
                bool isDisplacement = int.TryParse(inputList[2], out justForCheck);

                if (isDisplacement)
                    displacement = inputList[2];
                else
                    efficiency = inputList[2];
            }
            else if (inputList.Length == 4)
            {
                displacement = inputList[2];
                efficiency = inputList[3];
            }

            var engine = new Engine(model, powerStr, displacement, efficiency);
            engines.Add(engine);
        }

        return engines;
    }
}
