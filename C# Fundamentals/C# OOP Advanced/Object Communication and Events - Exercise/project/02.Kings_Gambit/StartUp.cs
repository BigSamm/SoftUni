using System;

namespace _02.Kings_Gambit
{
    class StartUp
    {
        static void Main()
        {
            IKing king = InitializeKing();
            
            var handler = new Handler();
            king.GetAttackedEvent += handler.OnAttackKing;

            string inputLine;
            while((inputLine = Console.ReadLine()) != "End")
            {
                if (inputLine == "Attack King")
                {
                    king.RespondAttack();
                }
                else
                {
                    var unitName = inputLine.Split()[1];
                    king.AllUnits.Find(u => u.Name == unitName).IsHitten();
                }
            }
        }

        private static IKing InitializeKing()
        {
            var kingName = Console.ReadLine();
            var king = new King(kingName);

            var royalGuardsNames = Console.ReadLine().Split();
            foreach (var royalGuardName in royalGuardsNames)
            {
                IUnit royalGuard = new RoyalGuard(royalGuardName);
                king.AddUnit(royalGuard);
            }

            var footmansNames = Console.ReadLine().Split();
            foreach (var footmanName in footmansNames)
            {
                IUnit footman = new Footman(footmanName);
                king.AddUnit(footman);
            }

            return king;
        }
    }
}
