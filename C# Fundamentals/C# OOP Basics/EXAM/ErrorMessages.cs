using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards
{
    public class ErrorMessages
    {
        public const string NotAliveCharacter = "Must be alive to perform this action!";
        public const string FullBag = "Bag is full!";
        public const string EmptyBag = "Bag is empty!";
        public const string ItemDoesNotExist = "No item with name {0} in bag!";
        public const string EmptyName = "Name cannot be null or whitespace!";
        public const string SelftAttack = "Cannot attack self!";
        public const string SameFactionAttack = "Friendly fire! Both characters are from {0} faction!";
        public const string OtherFactionHeal = "Cannot heal enemy character!";
        public const string InvalidCharacterType = "Invalid character type \"{0}\"!";
        public const string InvalidItemType = "Invalid item \"{0}\"!";
        public const string InvalidFactionType = "Invalid faction \"{0}\"!";
        public const string CharacterDoesNotExist = "Character {0} not found!";
        public const string EmptyItemPool = "No items left in pool!";
        public const string CanNotAttack = "{0} cannot attack!";
        public const string CanNotHeal = "{0} cannot heal!";
    }
}
