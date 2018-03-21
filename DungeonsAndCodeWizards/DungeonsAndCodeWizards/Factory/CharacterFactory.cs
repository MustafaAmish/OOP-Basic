using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Contract;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards.Factory
{
    public class CharacterFactory
    {
        public Character CreateCharacter(string fation,string type, string name)
        {
            
            bool bb = Enum.TryParse(typeof(Faction),fation, out object faction);
            if (!bb)
            {
                throw new ArgumentException($"Invalid faction " + faction + "!");
            }
            
            switch (type)
            {
                case "Warrior": return new Warrior(name, fation);
                case "Cleric": return new Cleric(name, fation);
                default: throw new ArgumentException($"Invalid character type " + type + "!");
            }
        }
    }
}
