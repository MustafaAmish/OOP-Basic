using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards.Contract
{
    public interface IAttackable
    {
      void  Attack(Character character);
    }
}
