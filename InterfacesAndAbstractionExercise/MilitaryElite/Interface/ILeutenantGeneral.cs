using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface ILeutenantGeneral:IPrivate
    {
        IReadOnlyCollection<ISoldier> Privates { get; }
        void AddPrivate(ISoldier solder);
    }
}
