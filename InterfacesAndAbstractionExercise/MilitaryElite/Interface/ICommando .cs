using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Interface
{
    interface ICommando:ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }
        void AddMision(IMission mission);
        void MisionCompleate(string mision);
    }
}
