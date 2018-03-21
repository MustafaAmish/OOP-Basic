using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Contract;

namespace DungeonsAndCodeWizards.Model
{
 public  abstract class Item:IItem
    {
        protected Item(int weight)
        {
            Weight = weight;
        }
        public int Weight { get; }

        public abstract void AffectCharacter(Character character);



    }
}
