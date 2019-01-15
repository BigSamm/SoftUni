using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            var damagePesho = int.Parse(Console.ReadLine());
            var damageGosho = int.Parse(Console.ReadLine());

            var healthPesho = 100;
            var healthGosho = 100;
            var br = 0;

            for (int i = 1; i < 9999999; i++)
            {
                br++;
                if (i % 2 == 1)
                {
                    healthGosho -= damagePesho;
                    if(healthGosho <= 0)
                    {
                        Console.WriteLine($"Pesho won in {br}th round.");
                        return;
                    }
                    else
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {healthGosho} health.");
                }
                else if(i % 2 == 0)
                {
                    healthPesho -= damageGosho;
                    if (healthPesho <= 0)
                    {
                        Console.WriteLine($"Gosho won in {br}th round.");
                        return;
                    }
                    else
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {healthPesho} health.");
                }
                //Console.WriteLine(healthPesho + "   " + healthGosho);
                if (i % 3 == 0)
                {
                    healthPesho += 10;
                    healthGosho += 10;
                }
                //Console.WriteLine(healthPesho + "   " + healthGosho);
            }




        }
    }
}
