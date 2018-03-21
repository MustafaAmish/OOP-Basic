using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Contract;

namespace DungeonsAndCodeWizards.Model
{
 public   class Warrior:Character,IAttackable
    {
        public void Attack(Character character)
        {
            if (IsAlive&&character.IsAlive)
            {
                if (this.Name==character.Name)
                {
                    throw new InvalidOperationException($"Invalid Operation: Cannot attack self!");
                }
                if (this.Faction==character.Faction)
                {
                    throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction.ToString()} faction!");
                }
                var hitPoint = this.AbilityPoints;
                hitPoint -= character.Armor;
                if (hitPoint>0)
                {
                    character.Armor = 0;
                    character.Health -= hitPoint;
                    if (character.Health<=0)
                    {
                        character.IsAlive = false;
                    }
                }
            }
        }
        private static Satchel bag=>new Satchel();
        public Warrior(string name, string faction) : base(name, 100, 50, 40, new Satchel(), faction)
        {
        }
    }
}
