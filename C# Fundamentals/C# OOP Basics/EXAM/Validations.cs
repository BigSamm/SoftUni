using DungeonsAndCodeWizards.Models;
using DungeonsAndCodeWizards.Models.Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class Validations
    {
        public static void ValidateCharacterAlive(Character character)
        {
            if (character.IsAlive == false)
                throw new InvalidOperationException(ErrorMessages.NotAliveCharacter);
        }



        public static void AttackCheck(Character firstChar, Character secondChar)
        {
            if (firstChar == secondChar)
                throw new InvalidOperationException(ErrorMessages.SelftAttack);

            if (firstChar.Faction == secondChar.Faction)
                throw new ArgumentException(String.Format(ErrorMessages.SameFactionAttack, firstChar.Faction));
        }

        public static void HealCheck(Character firstChar, Character secondChar)
        {
            if (firstChar.Faction != secondChar.Faction)
                throw new InvalidOperationException(ErrorMessages.OtherFactionHeal);
        }

        public static void ValidateFaction(string factionType)
        {
            var isValidFaction = Enum.TryParse<Faction>(factionType, out Faction faction);

            if (!isValidFaction)
                throw new ArgumentException(String.Format(ErrorMessages.InvalidFactionType, factionType));
        }
    }
}
