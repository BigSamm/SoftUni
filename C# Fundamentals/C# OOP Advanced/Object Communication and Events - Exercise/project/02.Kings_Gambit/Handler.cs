using System;
using System.Linq;

public class Handler
{
    public void OnAttackKing(object sender, AttackKingEventArgs args)
    {
        Console.WriteLine($"King {args.KingName} is under attack!");

        foreach (RoyalGuard royalGuard in args.AliveUnits.Where(u => u is RoyalGuard))
        {
            Console.WriteLine(royalGuard.RespondAttack());
        }

        foreach (Footman footman in args.AliveUnits.Where(u => u is Footman))
        {
            Console.WriteLine(footman.RespondAttack());
        }
    }
}