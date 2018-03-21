using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonsAndCodeWizards.Factory;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards
{
    public class DungeonMaster
    {
        private List<Character> characters;
        private CharacterFactory character;
        private Stack<Item> items;
        private ItemFactory item;
        private bool isEnd;
        private bool last;
        private int count;

        public DungeonMaster()
        {
            characters = new List<Character>();
            character = new CharacterFactory();
            items = new Stack<Item>();
            item = new ItemFactory();
            isEnd = false;
            last = false;
            count = 0;
        }


        public string JoinParty(string[] args)
        {
            var fation = args[0];
            var type = args[1];
            var name = args[2];
            var cc = character.CreateCharacter(fation,type,name);

            characters.Add(cc);
            return $"{name} joined the party!";
        }

        public string AddItemToPool(string[] args)
        {
            items.Push(item.CreateItem(args[0]));
            return $"{args[0]} added to pool.";
        }

        public string PickUpItem(string[] args)
        {
            var name = "";
            foreach (var s in args)
            {
                name += s;
            }
            var carecter = characters.FirstOrDefault(x => x.Name == name);
            if (carecter == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }
            else if (items.Count == 0)
            {
                throw new InvalidOperationException("No items left in pool!");
            }
            carecter.Bag.AddItem(items.Peek());
            return $"{carecter.Name} picked up {items.Pop().GetType().Name}!";
        }

        public string UseItem(string[] args)
        {
            var name = args[0];

            var carecter = characters.FirstOrDefault(n => n.Name == name);
            if (carecter == null)
            {
                throw new ArgumentException($"Character {name} not found!");
            }
            var itemmm = carecter.Bag.GetItem(args[1]);
            carecter.UseItem(itemmm);
            return $"{carecter.Name} used {args[1]}.";
        }

        public string UseItemOn(string[] args)
        {
            var giverName = args[0];
            var receiverName = characters.First(c => c.Name == args[1]);

            var careter = characters.First(c => c.Name == giverName);
            var itemName = careter.Bag.GetItem(args[2]);
            careter.UseItemOn(itemName, receiverName);
            return $"{giverName} used {itemName.GetType().Name} on {receiverName.Name}.";

        }

        public string GiveCharacterItem(string[] args)
        {
            var giverName = args[0];
            var receiverName = characters.First(c => c.Name == args[1]);

            var careter = characters.First(c => c.Name == giverName);
            var itemName = careter.Bag.GetItem(args[2]);
            careter.GiveCharacterItem(itemName, receiverName);
            return $"{giverName} gave {receiverName.Name} {itemName.GetType().Name}.";

        }

        public string GetStats()
        {
            var sb = new StringBuilder();
            //var status = "Alive";
            foreach (var character1 in characters.OrderByDescending(c => c.IsAlive).ThenByDescending(c => c.Health))
            {
                //if (!character1.IsAlive)
                //{
                //    status = "Dead";
                //}
                sb.AppendLine(character1.ToString());
            }

            return sb.ToString().Trim();
        }

        public string Attack(string[] args)
        {
            var attackerName = characters.FirstOrDefault(c => c.Name == args[0]);
            if (attackerName == null)
            {
                throw new ArgumentException($"Character {args[0]} not found!");
            }
            var receiverName = characters.FirstOrDefault(c => c.Name == args[1]);
            if (receiverName == null)
            {
                throw new ArgumentException($"Character {args[1]} not found!");
            }
            if (attackerName.GetType().Name != "Warrior")
            {
                throw new ArgumentException($"{attackerName.Name} cannot attack!");
            }
           
            attackerName.Attack(receiverName);
            var sb = new StringBuilder();
            sb.AppendLine(
                    $"{attackerName.Name} attacks {receiverName.Name} for {attackerName.AbilityPoints} hit points! {receiverName.Name} has {receiverName.Health}/{receiverName.BaseHealth} HP and {receiverName.Armor}/{receiverName.BaseArmor} AP left!");
            if (!receiverName.IsAlive)
            {
                sb.AppendLine($"{receiverName.Name} is dead!");
            }

            return sb.ToString().Trim();
        }

        public string Heal(string[] args)
        {
            var healerName = characters.FirstOrDefault(c => c.Name == args[0]);
            if (healerName == null)
            {
                throw new ArgumentException($"Character {args[0]} not found!");
            }
            var healingReceiverName = characters.FirstOrDefault(c => c.Name == args[1]);
            if (healingReceiverName == null)
            {
                throw new ArgumentException($"Character {args[1]} not found!");
            }
            var healtBefor = healingReceiverName.Health;
            if (healerName.GetType().Name != "Cleric")
            {
                throw new ArgumentException($"{healerName.Name} cannot heal!");
            }
            healerName.Heal(healingReceiverName);
            return $"{healerName.Name} heals {healingReceiverName.Name} for {healerName.AbilityPoints}! {healingReceiverName.Name} has {healingReceiverName.Health} health now!";
        }

        public string EndTurn(string[] args)
        {
            var sb = new StringBuilder();
            foreach (var character1 in characters.Where(c => c.IsAlive ))
            {
                var heltbefor = character1.Health;
                character1.Rest();
                sb.AppendLine($"{character1.Name} rests ({heltbefor} => {character1.Health})");
            }
            if (characters.Count(c => c.IsAlive) == 1 && count == 1)
            {
                last = true;

            }
            if (characters.Count(c => c.IsAlive) == 1)
            {
                count++;
            }
            else
            {
                count = 0;
            }
            return sb.ToString().Trim();

        }

        public bool IsGameOver()
        {

            return last;
        }
    }
}
