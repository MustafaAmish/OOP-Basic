﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }
        void GetCoprs(string type);

    }
}
