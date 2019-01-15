using System;
using System.Linq;
using System.Text;

namespace _03.Jarvis
{
    class Program
    {
        static void Main()
        {
            Robot robot = InitializeRobot();

            string input;
            while ((input = Console.ReadLine()) != "Assemble!")
            {
                AddComponent(input, robot);
            }

            Console.WriteLine(robot);
        }

        private static void AddComponent(string input, Robot robot)
        {
            string[] args = input.Split();
            string componentType = args[0].ToLower();
            int energyConsumption = int.Parse(args[1]);

            switch (componentType)
            {
                case "head":
                    int iq = int.Parse(args[2]);
                    string skinMaterial = Char.ToUpper(args[3].First()) + args[3].Substring(1).ToLower();
                    Head head = new Head(energyConsumption, iq, skinMaterial);
                    robot.AddHead(head);
                    break;
                case "torso":
                    double processorSize = double.Parse(args[2]);
                    string housingMaterial = Char.ToUpper(args[3].First()) + args[3].Substring(1).ToLower();
                    Torso torso = new Torso(energyConsumption, processorSize, housingMaterial);
                    robot.AddTorso(torso);
                    break;
                case "leg":
                    int strength = int.Parse(args[2]);
                    int speed = int.Parse(args[3]);
                    Leg leg = new Leg(energyConsumption, strength, speed);
                    robot.AddLeg(leg);
                    break;
                case "arm":
                    int reachDistance = int.Parse(args[2]);
                    int fingersCount = int.Parse(args[3]);
                    Arm arm = new Arm(energyConsumption, reachDistance, fingersCount);
                    robot.AddArm(arm);
                    break;
            }
        }

        private static Robot InitializeRobot()
        {
            long maxEnergyCapacity = long.Parse(Console.ReadLine());
            Robot robot = new Robot(maxEnergyCapacity);

            return robot;
        }
    }

    public class Robot
    {
        public Robot(long maxEnergyCapacity)
        {
            this.Name = "Jarvis";

            this.MaxEnergyCapacity = maxEnergyCapacity;
        }

        public string Name { get; private set; }

        public long MaxEnergyCapacity { get; private set; }

        public long Energy => this.CalculateEnergy();

        public Head Head { get; private set; }

        public Torso Torso { get; private set; }

        public Leg LeftLeg { get; private set; }

        public Leg RightLeg { get; private set; }

        public Arm LeftArm { get; private set; }

        public Arm RightArm { get; private set; }

        private long CalculateEnergy()
        {
            int result = this.Head.EnergyConsumption + this.Torso.EnergyConsumption +
                         this.LeftLeg.EnergyConsumption + this.RightLeg.EnergyConsumption +
                         this.LeftArm.EnergyConsumption + this.RightArm.EnergyConsumption;

            return result;
        }

        public void AddHead(Head head)
        {
            if (this.Head == null)
            {
                this.Head = head;
            }
            else if (head.EnergyConsumption < this.Head.EnergyConsumption)
            {
                this.Head = head;
            }
        }

        public void AddTorso(Torso torso)
        {
            if (this.Torso == null)
            {
                this.Torso = torso;
            }
            else if (torso.EnergyConsumption < this.Torso.EnergyConsumption)
            {
                this.Torso = torso;
            }
        }

        public void AddLeg(Leg leg)
        {
            if (this.LeftLeg == null)
            {
                this.LeftLeg = leg;
            }
            else if (this.RightLeg == null)
            {
                this.RightLeg = leg;
            }
            else if (leg.EnergyConsumption < this.LeftLeg.EnergyConsumption)
            {
                this.LeftLeg = leg;
            }
            else if (leg.EnergyConsumption < this.RightLeg.EnergyConsumption)
            {
                this.RightLeg = leg;
            }
        }

        public void AddArm(Arm arm)
        {
            if (this.LeftArm == null)
            {
                this.LeftArm = arm;
            }
            else if (this.RightArm == null)
            {
                this.RightArm = arm;
            }
            else if (arm.EnergyConsumption < this.LeftArm.EnergyConsumption)
            {
                this.LeftArm = arm;
            }
            else if (arm.EnergyConsumption < this.RightArm.EnergyConsumption)
            {
                this.RightArm = arm;
            }
        }

        public override string ToString()
        {
            if (this.Head == null || this.Torso == null || this.LeftLeg == null ||
                this.RightLeg == null || this.LeftArm == null || this.RightArm == null)
            {
                return "We need more parts!";
            }

            if (this.Energy > this.MaxEnergyCapacity)
            {
                return "We need more power!";
            }

            var result = new StringBuilder();
            result.AppendLine(this.Name + ":");
            result.AppendLine(this.Head.ToString());
            result.AppendLine(this.Torso.ToString());

            this.AppendArms(result);
            this.AppendLegs(result);

            return result.ToString();
        }

        private void AppendLegs(StringBuilder result)
        {
            if (this.LeftLeg.EnergyConsumption < this.RightLeg.EnergyConsumption)
            {
                result.AppendLine(this.LeftLeg.ToString());
                result.Append(this.RightLeg.ToString());
            }
            else
            {
                result.AppendLine(this.RightLeg.ToString());
                result.Append(this.LeftLeg.ToString());
            }
        }

        private void AppendArms(StringBuilder result)
        {
            if (this.LeftArm.EnergyConsumption < this.RightArm.EnergyConsumption)
            {
                result.AppendLine(this.LeftArm.ToString());
                result.AppendLine(this.RightArm.ToString());
            }
            else
            {
                result.AppendLine(this.RightArm.ToString());
                result.AppendLine(this.LeftArm.ToString());
            }
        }
    }

    public class Head
    {
        public Head(int energyConsumption, int iq, string skinMaterial)
        {
            this.EnergyConsumption = energyConsumption;
            this.IQ = iq;
            this.SkinMaterial = skinMaterial;
        }

        public int EnergyConsumption { get; private set; }

        public int IQ { get; private set; }

        public string SkinMaterial { get; private set; }

        public override string ToString()
        {
            string result = "#Head:" + Environment.NewLine +
                $"###Energy consumption: {this.EnergyConsumption}" + Environment.NewLine +
                $"###IQ: {this.IQ}" + Environment.NewLine +
                $"###Skin material: {this.SkinMaterial}";

            return result;
        }
    }

    public class Torso
    {
        public Torso(int energyConsumption, double processorSize, string housingMaterial)
        {
            this.EnergyConsumption = energyConsumption;
            this.ProcessorSize = processorSize;
            this.HousingMaterial = housingMaterial;
        }

        public int EnergyConsumption { get; private set; }

        public double ProcessorSize { get; private set; }

        public string HousingMaterial { get; private set; }

        public override string ToString()
        {
            string result = "#Torso:" + Environment.NewLine +
                $"###Energy consumption: {this.EnergyConsumption}" + Environment.NewLine +
                $"###Processor size: {this.ProcessorSize:f1}" + Environment.NewLine +
                $"###Corpus material: {this.HousingMaterial}";

            return result;
        }
    }

    public class Leg
    {
        public Leg(int energyConsumption, int strength, int speed)
        {
            this.EnergyConsumption = energyConsumption;
            this.Strength = strength;
            this.Speed = speed;
        }

        public int EnergyConsumption { get; private set; }

        public int Strength { get; private set; }

        public int Speed { get; private set; }

        public override string ToString()
        {
            string result = "#Leg:" + Environment.NewLine +
                $"###Energy consumption: {this.EnergyConsumption}" + Environment.NewLine +
                $"###Strength: {this.Strength}" + Environment.NewLine +
                $"###Speed: {this.Speed}";

            return result;
        }
    }

    public class Arm
    {
        public Arm(int energyConsumption, int reachDistance, int fingersCount)
        {
            this.EnergyConsumption = energyConsumption;
            this.ReachDistance = reachDistance;
            this.FingersCount = fingersCount;
        }

        public int EnergyConsumption { get; private set; }

        public int ReachDistance { get; private set; }

        public int FingersCount { get; private set; }

        public override string ToString()
        {
            string result = "#Arm:" + Environment.NewLine +
                $"###Energy consumption: {this.EnergyConsumption}" + Environment.NewLine +
                $"###Reach: {this.ReachDistance}" + Environment.NewLine +
                $"###Fingers: {this.FingersCount}";

            return result;
        }
    }
}