using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DungeonsAndCodeWizards.Contract;

namespace DungeonsAndCodeWizards.Model
{
  public abstract class Bag:IBag
    {
        protected Bag(int capacity)
        {
            Capacity =capacity;
            Items =new List<Item>();
            Item=new List<Item>();
            Load = 0;

        }
        private List<Item> item;

        public List<Item> Item
        {
            get { return item; }
           private set { item = value; }
        }

        public int Capacity { get; private set; }
        private int load;

        public int Load
        {
            get { return load; }
            private set { load = value; }
        }
        private IReadOnlyCollection<Item> items;
        public IReadOnlyCollection<Item> Items
        {
            get => items;
          private  set
            {
                
                items = (IReadOnlyCollection < Item >) item;
            }
        }

        public Item GetItem(string name)
        {
            if (Item.Count==0)
            {
                throw new InvalidOperationException("Invalid Operation: Bag is empty!");
            }
            else if (Item.All(x => x.GetType().Name != name))
            {
                throw new ArgumentException($"Parameter Error: No item with name {name} in bag!");
            }
            Item mmm = Item.First(x => x.GetType().Name == name);
            Load -= mmm.Weight;
            Item.Remove(mmm);
            return mmm;

        }

        public void AddItem(Item itemmm)
        {
            if (Load+itemmm.Weight>Capacity)
            {
                throw new InvalidOperationException("Invalid Operation: Bag is full!");
            }
            Load += itemmm.Weight;
            Item.Add(itemmm);
        }
    }
}
