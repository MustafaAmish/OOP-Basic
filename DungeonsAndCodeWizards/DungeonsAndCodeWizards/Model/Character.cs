using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Contract;

namespace DungeonsAndCodeWizards.Model
{
   public abstract class Character: IWarrior,ICleric
    {
        protected Character(string name, double health, double armor, double abilityPoints, Bag bag, string faction)
        {
            Name = name;
            Health = health;
            Armor = armor;
            AbilityPoints = abilityPoints;
            Bag = bag;
            Faction = faction;
            IsAlive = true;
            BaseArmor = armor;
            BaseHealth = health;
            RestHealMultiplier = 0.2;
        }
       

        private string name;

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be null or whitespace!");
                }
                name = value;
            }
        }
        public double BaseHealth { get; }
        public double Health { get; set; }
        public double BaseArmor { get; }
        public double Armor { get; set; }
        public double AbilityPoints { get; }
        public IBag Bag { get; }
        public string Faction { get; }
        public bool IsAlive { get; set; }
        public double RestHealMultiplier { get; }

        public void TakeDamage(double hitPoints)
        {
            if (IsAlive)
            {
                hitPoints -= Armor;
                if (hitPoints>0)
                {
                    Health -= hitPoints;
                    if (Health<=0)
                    {
                        IsAlive = false;
                    }
                }
            }
        }

        public void Rest()
        {
            if (IsAlive)
            {
                Health += BaseHealth * RestHealMultiplier;
                if (Health>BaseHealth)
                {
                    Health = BaseHealth;
                }
            }
        }

        public void UseItem(Item item)
        {
            if (IsAlive)
            {
               item.AffectCharacter(this);
            }
        }

        public void UseItemOn(Item item, Character character)
        {
            if (character.IsAlive&&IsAlive)
            {
                //var name = item.GetType().Name;
               // Bag.GetItem(name);
                item.AffectCharacter(character);

            }
        }

        public void GiveCharacterItem(Item item, Character character)
        {
            if (character.IsAlive && IsAlive)
            {
                //var name = item.GetType().Name;
                //Bag.GetItem(name);
                character.Bag.AddItem(item);

            }
        }

        public void ReceiveItem(Item item)
        {
            Bag.AddItem(item);
        }

        public  void Attack(Character character)
        {
            if (IsAlive && character.IsAlive)
            {
                if (this.Name == character.Name)
                {
                    throw new InvalidOperationException($"Invalid Operation: Cannot attack self!");
                }
                if (this.Faction == character.Faction)
                {
                    throw new ArgumentException($"Friendly fire! Both characters are from {this.Faction} faction!");
                }
                var hitPoint = this.AbilityPoints;
       
                hitPoint -= character.Armor;
                character.Armor -= this.AbilityPoints;
                if (hitPoint > 0)
                {
                    character.Armor = 0;
                    character.Health -= hitPoint;
                    if (character.Health <= 0)
                    {
                        character.Health = 0;
                        character.IsAlive = false;
                    }
                }
            }
        }

        public virtual void Heal(Character character)
        {
            if (IsAlive && character.IsAlive)
            {
                if (Faction != character.Faction)
                {
                    throw new InvalidOperationException("Invalid Operation: Cannot heal enemy character!");
                }
                character.Health += AbilityPoints;
            }
        }

        public override string ToString()
        {
            string stats = "Alive";
            if (!IsAlive)
            {
                stats = "Dead";
            }
            return $"{name} - HP: {Health}/{BaseHealth}, AP: {Armor}/{BaseArmor}, Status: {stats}";
        }
    }
}
