using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards.Contract
{
    public interface IBag
    {
        int Capacity { get; }
        int Load { get; }
        IReadOnlyCollection<Item> Items { get; }
        void AddItem(Item item);
        Item GetItem(string name);
    }
}
