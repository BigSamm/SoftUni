using System;
using System.Linq;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        internal string Name
        {
            get{ return this.name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Name cannot be empty.");
                this.name = value;
            }
        }

        internal int Age
        {
            get { return this.age; }
            private set
            {
                if (value < 0 || value > 15)
                    throw new ArgumentException($"Age should be between {MIN_AGE} and {MAX_AGE}.");
                this.age = value;
            }
        }

        internal double ProductPerDay
        {
			get { return this.CalculateProductPerDay(); }
        }

        private double CalculateProductPerDay()
        {
            switch (this.Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
