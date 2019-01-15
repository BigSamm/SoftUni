using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Key_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            var bulletPrice = int.Parse(Console.ReadLine());
            var gunBarrelSize = int.Parse(Console.ReadLine());
            var bulletsInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);
            var locksInput = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Reverse();
            var valueOfIntelligence = int.Parse(Console.ReadLine());

            var bullets = new Stack<int>(bulletsInput);
            var locks = new Stack<int>(locksInput);

            var usedBullets = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                if (usedBullets % gunBarrelSize == 0 && usedBullets != 0)
                    Console.WriteLine("Reloading!");

                var currentBullet = bullets.Pop();
                var currentLock = locks.Pop();

                if (currentBullet <= currentLock)
                {
                    Console.WriteLine("Bang!");
                }
                else
                {
                    Console.WriteLine("Ping!");
                    locks.Push(currentLock);
                }

                usedBullets++;
            }

            if (usedBullets % gunBarrelSize == 0 && usedBullets != 0 && bullets.Count > 0)
                Console.WriteLine("Reloading!");

            if (locks.Count > 0)
            {
                var locksLeft = locks.Count;
                Console.WriteLine($"Couldn't get through. Locks left: {locksLeft}");
            }
            else
            {
                var bulletsLeft = bullets.Count;
                var moneyEarned = valueOfIntelligence - (usedBullets * bulletPrice);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}