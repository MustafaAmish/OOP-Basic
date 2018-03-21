using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonsAndCodeWizards.Model
{
 public   class PoisonPotion:Item
    {
        public PoisonPotion() : base(5)
        {
        }

        public override void AffectCharacter(Character character)
        {
            if (character.IsAlive)
            {
                character.Health -= 20;
                if (character.Health <= 0)
                {
                    character.IsAlive = false;
                }
            }
            
        }
    }
}
