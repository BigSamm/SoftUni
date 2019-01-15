using DungeonsAndCodeWizards.Factories;
using DungeonsAndCodeWizards.Models;
using DungeonsAndCodeWizards.Models.Characters;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DungeonsAndCodeWizards.Business_Logic
{
    public class DungeonMaster
    {
        private List<Character> allCharacters = new List<Character>();
        private Stack<Item> itemPool = new Stack<Item>();
        
        private CharacterFactory characterFactory;
        private ItemFactory itemFactory;

        private int lastSurvivorRounds = 0;

        public DungeonMaster()
        {
            this.allCharacters = new List<Character>();
            this.itemPool = new Stack<Item>();
            
            this.characterFactory = new CharacterFactory();
            this.itemFactory = new ItemFactory();
        }

        public string JoinParty(string[] args)
        {
            var factionType = args[0];
            var characterType = args[1];
            var characterName = args[2];
            
            var character = characterFactory.CreateCharacter(factionType, characterType, characterName);
            allCharacters.Add(character);

            var result = $"{character.Name} joined the party!";
            return result;
        }

        public string AddItemToPool(string[] args)
        {
            var type = args[0];
            var item = itemFactory.CreateItem(type);
            itemPool.Push(item);

            var itemName = item.GetType().Name;
            var result = $"{itemName} added to pool.";
            return result;
        }

        public string PickUpItem(string[] args)
        {
            var character = GetCharacter(args[0]);

            if (this.itemPool.Count == 0)
                throw new InvalidOperationException(ErrorMessages.EmptyItemPool);

            var item = itemPool.Pop();
            character.ReceiveItem(item);

            var itemName = item.GetType().Name;
            var result = $"{character.Name} picked up {itemName}!";
            return result;
        }

        public string UseItem(string[] args)
        {
            var character = GetCharacter(args[0]);

            var itemName = args[1];
            var item = character.Bag.GetItem(itemName);

            character.UseItem(item);
            
            var result = $"{character.Name} used {itemName}.";
            return result;
        }

        public string UseItemOn(string[] args)
        {
            var giverChar = GetCharacter(args[0]);
            var receiverChar = GetCharacter(args[1]);
            
            var itemName = args[2];
            var item = giverChar.Bag.GetItem(itemName);
            giverChar.UseItemOn(item, receiverChar);

            var result = $"{giverChar.Name} used {itemName} on {receiverChar.Name}.";
            return result;
        }

        public string GiveCharacterItem(string[] args)
        {
            var giverChar = GetCharacter(args[0]);
            var receiverChar = GetCharacter(args[1]);

            var itemName = args[2];
            var item = giverChar.Bag.GetItem(itemName);
            giverChar.GiveCharacterItem(item, receiverChar);

            var result = $"{giverChar.Name} gave {receiverChar.Name} {itemName}.";
            return result;
        }

        public string GetStats()
        {
            var orderedCharacters = this.allCharacters.OrderByDescending(ch => ch.IsAlive)
                .ThenByDescending(ch => ch.Health);

            var result = new StringBuilder();

            foreach (var character in orderedCharacters)
            {
                result.Append(character + Environment.NewLine);
            }

            return result.ToString().TrimEnd();
        }

        //maybe
        public string Attack(string[] args)
        {
            var attackerChar = GetCharacter(args[0]);
            var receiver = GetCharacter(args[1]);

            if (!(attackerChar is IAttackable))
                throw new ArgumentException(String.Format(ErrorMessages.CanNotAttack, attackerChar.Name));

            var attacker = (Warrior)attackerChar;
            attacker.Attack(receiver);

            var result = $"{attacker.Name} attacks {receiver.Name} for {attacker.AbilityPoints} hit points! " +
                         $"{receiver.Name} has {receiver.Health}/{receiver.BaseHealth} HP and " +
                         $"{receiver.Armor}/{receiver.BaseArmor} AP left!";

            if (!receiver.IsAlive)
                result += Environment.NewLine + $"{receiver.Name} is dead!";

            return result;
        }

        //maybe
        public string Heal(string[] args)
        {
            var healerChar = GetCharacter(args[0]);
            var receiver = GetCharacter(args[1]);

            if (!(healerChar is IHealable))
                throw new ArgumentException(String.Format(ErrorMessages.CanNotHeal, healerChar.Name));

            var healer = (Cleric)healerChar;
            healer.Heal(receiver);

            var result = $"{healer.Name} heals {receiver.Name} for {healer.AbilityPoints}! {receiver.Name} has {receiver.Health} health now!";
            return result;
        }

        public string EndTurn(string[] args)
        {
            var aliveChars = allCharacters.Where(ch => ch.IsAlive == true).ToList();

            if (aliveChars.Count <= 1)
                lastSurvivorRounds++;

            var result = new StringBuilder();
            foreach (var character in aliveChars)
            {
                var healthBeforeRest = character.Health;
                character.Rest();
                var currentHealth = character.Health;

                result.Append($"{character.Name} rests ({healthBeforeRest} => {currentHealth})" + Environment.NewLine);
            }

            return result.ToString().TrimEnd();
        }

        public bool IsGameOver()
        {
            if (lastSurvivorRounds > 1)
                return true;
            else
                return false;
        }

        private void ValidateCharacterExist(Character character, string name)
        {
            if (character == null)
                throw new ArgumentException(String.Format(ErrorMessages.CharacterDoesNotExist, name));
        }

        private Character GetCharacter(string name)
        {
            var character = allCharacters.SingleOrDefault(ch => ch.Name == name);
            ValidateCharacterExist(character, name);
            return character;
        }
    }
}
