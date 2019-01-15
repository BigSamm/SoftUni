using System;

class Program
{
    public static Car car;
    public static Truck truck;

    static void Main(string[] args)
    {
        car = ParseCar();
        truck = ParseTruck();

        var linesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < linesCount; i++)
        {
            var inputList = Console.ReadLine().Split();
            switch (inputList[0])
            {
                case "Drive": Drive(inputList); break;
                case "Refuel": Refuel(inputList); break;
            }
        }

        Console.WriteLine($"Car: {car.Fuel:f2}");
        Console.WriteLine($"Truck: {truck.Fuel:f2}");
    }

    private static void Refuel(string[] inputList)
    {
        var type = inputList[1];
        var liters = double.Parse(inputList[2]);

        switch (type)
        {
            case "Car": car.Refuel(liters); break;
            case "Truck": truck.Refuel(liters); break;
        }
    }

    private static void Drive(string[] inputList)
    {
        var type = inputList[1];
        var distance = double.Parse(inputList[2]);

        switch (type)
        {
            case "Car": car.Drive(distance); break;
            case "Truck": truck.Drive(distance); break;
        }
    }

    private static Truck ParseTruck()
    {
        var truckList = Console.ReadLine().Split();
        var truckFuel = double.Parse(truckList[1]);
        var truckExpense = double.Parse(truckList[2]);

        var truck = new Truck(truckFuel, truckExpense);
        return truck;
    }

    private static Car ParseCar()
    {
        var carList = Console.ReadLine().Split();
        var carFuel = double.Parse(carList[1]);
        var carExpense = double.Parse(carList[2]);

        var car = new Car(carFuel, carExpense);
        return car;
    }
}