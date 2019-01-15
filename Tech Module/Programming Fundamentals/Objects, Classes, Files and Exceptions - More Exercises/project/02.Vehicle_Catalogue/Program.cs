using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            List<Vehicle> vehicles = InitializeVehicles();

            string model;
            while ((model = Console.ReadLine()) != "Close the Catalogue")
            {
                PrintModel(vehicles, model);
            }

            PrintTypeAverageHorsepower(vehicles, "Car");
            PrintTypeAverageHorsepower(vehicles, "Truck");
        }

        private static void PrintTypeAverageHorsepower(List<Vehicle> vehicles, string type)
        {
            Vehicle[] validVehicles = vehicles.Where(v => v.Type == type).ToArray();
            double averageHorsepower = validVehicles.Length == 0 ? 0.0 : validVehicles.Average(v => v.Horsepower);

            Console.WriteLine($"{type}s have average horsepower of: {averageHorsepower:f2}.");
        }

        private static void PrintModel(List<Vehicle> vehicles, string model)
        {
            Vehicle vehicle = vehicles.Find(v => v.Model == model);

            if (vehicle != null)
                Console.WriteLine(vehicle);
        }

        private static List<Vehicle> InitializeVehicles()
        {
            var vehicles = new List<Vehicle>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] args = input.Split();

                string type = args[0];
                type = Char.ToUpper(type.First()) + type.Substring(1).ToLower();

                string model = args[1];
                string color = args[2];
                int horsepower = int.Parse(args[3]);

                Vehicle vehicle = new Vehicle(type, model, color, horsepower);
                vehicles.Add(vehicle);
            }

            return vehicles;
        }
    }

    public class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Type { get; }

        public string Model { get; }

        public string Color { get; }

        public int Horsepower { get; }

        public override string ToString()
        {
            return $"Type: {this.Type}" + Environment.NewLine +
                   $"Model: {this.Model}" + Environment.NewLine +
                   $"Color: {this.Color}" + Environment.NewLine +
                   $"Horsepower: {this.Horsepower}";
        }
    }
}
