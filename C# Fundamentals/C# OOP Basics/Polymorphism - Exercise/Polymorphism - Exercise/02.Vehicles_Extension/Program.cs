using System;

class Program
{
    public static Car car;
    public static Truck truck;
    public static Bus bus;

    static void Main(string[] args)
    {
        car = ParseCar();
        truck = ParseTruck();
        bus = ParseBus();

        var linesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < linesCount; i++)
        {
            var inputList = Console.ReadLine().Split();
            switch (inputList[0])
            {
                case "Drive": Drive(inputList); break;
                case "Refuel": Refuel(inputList); break;
                case "DriveEmpty": DriveEmpty(inputList); break;
            }
        }

        Console.WriteLine($"Car: {car.Fuel:f2}");
        Console.WriteLine($"Truck: {truck.Fuel:f2}");
        Console.WriteLine($"Bus: {bus.Fuel:f2}");
    }

    private static void DriveEmpty(string[] inputList)
    {
        var distance = double.Parse(inputList[2]);
        bus.DriveEmpty(distance);
    }

    private static void Refuel(string[] inputList)
    {
        var type = inputList[1];
        var liters = double.Parse(inputList[2]);

        switch (type)
        {
            case "Car": car.Refuel(liters); break;
            case "Truck": truck.Refuel(liters); break;
            case "Bus": bus.Refuel(liters); break;
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
            case "Bus": bus.Drive(distance); break;
        }
    }

    private static Bus ParseBus()
    {
        var busList = Console.ReadLine().Split();
        var fuel = double.Parse(busList[1]);
        var expense = double.Parse(busList[2]);
        var tankCapacity = double.Parse(busList[3]);

        var bus = new Bus(fuel, expense, tankCapacity);
        return bus;
    }

    private static Truck ParseTruck()
    {
        var truckList = Console.ReadLine().Split();
        var fuel = double.Parse(truckList[1]);
        var expense = double.Parse(truckList[2]);
        var tankCapacity = double.Parse(truckList[3]);

        var truck = new Truck(fuel, expense, tankCapacity);
        return truck;
    }

    private static Car ParseCar()
    {
        var carList = Console.ReadLine().Split();
        var fuel = double.Parse(carList[1]);
        var expense = double.Parse(carList[2]);
        var tankCapacity = double.Parse(carList[3]);

        var car = new Car(fuel, expense, tankCapacity);
        return car;
    }
}