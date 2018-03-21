using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards.Contract
{
  public  interface IItem
    {
        int Weight { get; }
        void AffectCharacter(Character character);
    }
}
