using DungeonsAndCodeWizards.Models;
using DungeonsAndCodeWizards.Models.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Factories
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string factionType, string type, string name)
        {
            Validations.ValidateFaction(factionType);
            var faction = Enum.Parse<Faction>(factionType);

            switch (type)
            {
                case "Warrior":
                    return new Warrior(name, faction);
                case "Cleric":
                    return new Cleric(name, faction);
                default:
                    throw new ArgumentException(String.Format(ErrorMessages.InvalidCharacterType, type));
            }
        }
    }
}
