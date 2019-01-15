using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Cleric : Character, IHealable
    {
        public Cleric(string name, Faction faction) 
            : base(name, 50, 25, 40, new Backpack(), faction)
        {
        }

        public override double RestHealMultiplier => 0.5;

        public void Heal(Character character)
        {
            Validations.ValidateCharacterAlive(this);
            Validations.ValidateCharacterAlive(character);

            Validations.HealCheck(this, character);

            character.IncreaseHealth(base.AbilityPoints);
        }
    }
}
