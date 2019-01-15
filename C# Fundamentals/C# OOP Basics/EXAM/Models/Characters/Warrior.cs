using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Models.Bags;

namespace DungeonsAndCodeWizards.Models.Characters
{
    public class Warrior : Character, IAttackable
    {
        public Warrior(string name, Faction faction) 
            : base(name, 100, 50, 40, new Satchel(), faction)
        {
        }

        public void Attack(Character character)
        {
            Validations.ValidateCharacterAlive(this);
            Validations.ValidateCharacterAlive(character);

            Validations.AttackCheck(this, character);

            character.TakeDamage(base.AbilityPoints);
        }
    }
}
