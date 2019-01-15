using DungeonsAndCodeWizards.Business_Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Engine
    {
        public void Run()
        {
            var dungeonMaster = new DungeonMaster();

            string inputLine;
            while(!String.IsNullOrWhiteSpace(inputLine = Console.ReadLine()))
            {
                var inputList = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var command = inputList.First();
                var args = inputList.Skip(1).ToArray();

                var isEnd = false;
                try
                {
                    switch (command)
                    {
                        case "JoinParty":
                            Console.WriteLine(dungeonMaster.JoinParty(args));
                            break;
                        case "AddItemToPool":
                            Console.WriteLine(dungeonMaster.AddItemToPool(args));
                            break;
                        case "PickUpItem":
                            Console.WriteLine(dungeonMaster.PickUpItem(args));
                            break;
                        case "UseItem":
                            Console.WriteLine(dungeonMaster.UseItem(args));
                            break;
                        case "UseItemOn":
                            Console.WriteLine(dungeonMaster.UseItemOn(args));
                            break;
                        case "GiveCharacterItem":
                            Console.WriteLine(dungeonMaster.GiveCharacterItem(args));
                            break;
                        case "GetStats":
                            Console.WriteLine(dungeonMaster.GetStats());
                            break;
                        case "Attack":
                            Console.WriteLine(dungeonMaster.Attack(args));
                            break;
                        case "Heal":
                            Console.WriteLine(dungeonMaster.Heal(args));
                            break;
                        case "EndTurn":
                            Console.WriteLine(dungeonMaster.EndTurn(args));
                            break;
                        case "IsGameOver":
                            isEnd = dungeonMaster.IsGameOver();
                            break;
                    }

                    if (isEnd)
                        break;
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException)
                        Console.WriteLine("Parameter Error: " + ex.Message);
                    else if (ex is InvalidOperationException)
                        Console.WriteLine("Invalid Operation: " + ex.Message);
                    else
                        throw ex;
                }
            }

            Console.WriteLine("Final stats:");
            Console.WriteLine(dungeonMaster.GetStats());
        }
    }
}
