using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Car> cars = GetAllCars();

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            var commandList = command.Split();
            if (commandList[0] != "Drive")
            {
                continue;
            }

            var model = commandList[1];
            var km = int.Parse(commandList[2]);
            DoCommand(model, km, cars);
        }

        foreach (var car in cars)
        {
            car.PrintCar();
        }
    }

    private static void DoCommand(string model, int km, List<Car> cars)
    {
        var car = cars.Find(c => c.Model == model);

        if (car.CanMoveDistance(km))
        {
            car.MoveDistance(km);
        }
        else
            Console.WriteLine("Insufficient fuel for the drive");
    }

    private static List<Car> GetAllCars()
    {
        var cars = new List<Car>();

        var n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var inputLineList = Console.ReadLine().Split();
            var model = inputLineList[0];
            var fuelAmount = double.Parse(inputLineList[1]);
            var fuelConsump = double.Parse(inputLineList[2]);

            var car = new Car(model, fuelAmount, fuelConsump);
            cars.Add(car);
        }

        return cars;
    }
}
