using System;
using System.Collections.Generic;
using System.Text;
using DungeonsAndCodeWizards.Model;

namespace DungeonsAndCodeWizards.Contract
{
    public interface IHealable
    {
        void Heal(Character character);
    }
}
