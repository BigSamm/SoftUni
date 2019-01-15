using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];
                Engine engine = ParseEngine(parameters);
                Cargo cargo = ParseCargo(parameters);

                var firstTier = GetCurrentTier(parameters[5], parameters[6]);
                var secondTier = GetCurrentTier(parameters[7], parameters[8]);
                var thirdTier = GetCurrentTier(parameters[9], parameters[10]);
                var fourthTier = GetCurrentTier(parameters[11], parameters[12]);

                var car = new Car(model, engine, cargo, firstTier, secondTier, thirdTier, fourthTier);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragileCars = cars
                    .Where(x => x.Cargo.Type == "fragile" && x.Tiers.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                fragileCars.ForEach(c => Console.WriteLine(c));
            }
            else
            {
                List<string> flamableCars = cars
                    .Where(x => x.Cargo.Type == "flamable" && x.Engine.Power > 250)
                    .Select(x => x.Model)
                    .ToList();

                flamableCars.ForEach(c => Console.WriteLine(c));
            }
        }

        private static Tier GetCurrentTier(string pressureStr, string ageStr)
        {
            double tierPressure = double.Parse(pressureStr);
            int tireAge = int.Parse(ageStr);

            var tier = new Tier(tierPressure, tireAge);
            return tier;
        }

        private static Cargo ParseCargo(string[] parameters)
        {
            int cargoWeight = int.Parse(parameters[3]);
            string cargoType = parameters[4];

            var cargo = new Cargo(cargoWeight, cargoType);
            return cargo;
        }

        private static Engine ParseEngine(string[] parameters)
        {
            int engineSpeed = int.Parse(parameters[1]);
            int enginePower = int.Parse(parameters[2]);

            var engine = new Engine(engineSpeed, enginePower);
            return engine;
        }
    }
}
