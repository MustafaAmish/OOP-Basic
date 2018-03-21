using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
   public interface IPrivate:ISoldier
    {
       
        decimal Salary { get; }
    }
}
