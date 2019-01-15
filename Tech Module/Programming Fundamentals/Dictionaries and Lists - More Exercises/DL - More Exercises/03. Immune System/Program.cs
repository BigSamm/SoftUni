using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Immune_System
{
    class Program
    {
        static void Main(string[] args)
        {
            var viruses = new List<string>();
            var health = double.Parse(Console.ReadLine());
            var initialHealth = health;
            for (;;)
            {
                var virus = Console.ReadLine();
                if (virus == "end")
                {
                    Console.WriteLine($"Final Health: {health}");
                    break;
                }
                double virusStrength = GetVirusStrength(virus);
                double timeToDefeat = virusStrength * virus.Length;
                
                if (viruses.Contains(virus))
                    timeToDefeat = Math.Floor(timeToDefeat / 3);
                viruses.Add(virus);

                var defeatMins = Math.Floor(timeToDefeat / 60);
                var defeatSecs = Math.Floor(timeToDefeat % 60);
                if (health >= timeToDefeat)
                {
                    health = Math.Floor(health - timeToDefeat);
                    Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeat} seconds");
                    Console.WriteLine($"{virus} defeated in {defeatMins}m {defeatSecs}s.");
                    Console.WriteLine($"Remaining health: {health}");
                    health = Math.Floor(health + health * 0.2);
                    if (health > initialHealth)
                        health = initialHealth;
                }
                else
                {
                    Console.WriteLine($"Virus {virus}: {virusStrength} => {timeToDefeat} seconds");
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
            }
        }

        static double GetVirusStrength(string virus)
        {
            char[] virusInChars = virus.ToCharArray();
            double virusStrength = 0;
            for (int i = 0; i < virusInChars.Length; i++)
            {
                virusStrength += virusInChars[i];
            }
            virusStrength = Math.Floor(virusStrength / 3);
            return virusStrength;
        }



    }
}
