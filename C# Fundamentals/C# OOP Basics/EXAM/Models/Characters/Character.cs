using DungeonsAndCodeWizards.Models.Bags;
using DungeonsAndCodeWizards.Models.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public abstract class Character
    {
        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, Faction faction)
        {
            this.Name = name;
            this.BaseHealth = health;
            this.Health = this.BaseHealth;
            this.BaseArmor = armor;
            this.Armor = this.BaseArmor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
            this.Faction = faction;
            this.IsAlive = true;
            this.RestHealMultiplier = .2;
        }

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ErrorMessages.EmptyName);
                name = value;
            }
        }
        
        public double BaseHealth { get; private set; }

        public double Health { get; set; }

        public double BaseArmor { get; private set; }

        public double Armor { get; set; }

        public double AbilityPoints { get; }

        public Bag Bag { get; }

        public Faction Faction { get; }

        public bool IsAlive { get; private set; }

        public virtual double RestHealMultiplier { get; }

        public string Status => this.IsAlive ? "Alive" : "Dead";

        public void TakeDamage(double hitPoints)
        {
            Validations.ValidateCharacterAlive(this);

            var armorReduce = Math.Min(this.Armor, hitPoints);
            this.Armor -= armorReduce;

            hitPoints -= armorReduce;
            this.Health -= hitPoints;

            CheckForDead();
        }

        //maybe
        public void Rest()
        {
            Validations.ValidateCharacterAlive(this);

            this.Health += this.BaseHealth * this.RestHealMultiplier;

            if (this.Health > this.BaseHealth)
                this.Health = this.BaseHealth;
        }

        //maybe
        public void UseItem(Item item)
        {
            Validations.ValidateCharacterAlive(this);

            if (this.Bag.ExistItem(item))
            {
                this.Bag.UseItem(item);
            }

            item.AffectCharacter(this);
        }

        //maybe
        public void UseItemOn(Item item, Character character)
        {
            Validations.ValidateCharacterAlive(this);
            Validations.ValidateCharacterAlive(character);

            item.AffectCharacter(character);
        }

        //maybe
        public void GiveCharacterItem(Item item, Character character)
        {
            Validations.ValidateCharacterAlive(this);
            Validations.ValidateCharacterAlive(character);

            character.ReceiveItem(item);
        }

        public void ReceiveItem(Item item)
        {
            Validations.ValidateCharacterAlive(this);

            this.Bag.AddItem(item);
        }
        
        public void IncreaseHealth(double health)
        {
            this.Health += health;

            if (this.Health > this.BaseHealth)
                this.Health = this.BaseHealth;
        }

        public void DecreaseHealth(double health)
        {
            this.Health -= 20;

            CheckForDead();
        }

        public void RestoreArmor()
        {
            this.Armor = this.BaseArmor;
        }

        public void CheckForDead()
        {
            if (this.Health <= 0)
            {
                this.IsAlive = false;
                this.Health = 0;
            }
        }

        public override string ToString()
        {
            var result = $"{this.Name} - HP: {this.Health}/{this.BaseHealth}, " +
                $"AP: {this.Armor}/{this.BaseArmor}, Status: {this.Status}";
            return result;
        }
    }
}
