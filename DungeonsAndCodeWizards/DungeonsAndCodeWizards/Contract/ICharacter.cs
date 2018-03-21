using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards.Contract
{
   public interface ICharacter
    {
         string Name { get; }
        double BaseHealth { get; }
        double Health { get; }
        double BaseArmor { get; }
        double Armor { get; }
        double AbilityPoints { get; }
        IBag Bag { get; }
        string Faction { get; }
        bool IsAlive { get; }
        double RestHealMultiplier { get; }
        void TakeDamage(double hitPoints);
        void Rest();
        void UseItem(Item item);
        void UseItemOn(Item item, Character character);
        void GiveCharacterItem(Item item, Character character);
        void ReceiveItem(Item item);

    }
}
