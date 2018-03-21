using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Contract;

namespace DungeonsAndCodeWizards.Model
{
   public class Cleric:Character,IHealable
    {
        public override void Heal(Character character)
        {
            if (IsAlive&&character.IsAlive)
            {
                if (Faction!=character.Faction)
                {
                    throw new InvalidOperationException("Cannot heal enemy character!");
                }
                character.Health += AbilityPoints;
            }
        }
        private static Backpack bag => new Backpack();
        public Cleric(string name, string faction) : base(name, 50, 25, 40, bag, faction)
        {
        }
    }
}
