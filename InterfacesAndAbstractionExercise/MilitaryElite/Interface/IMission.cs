using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
    interface IMission
    {
        string CodeName { get; }
        State State { get; }
        void Complyte();

    }
}
