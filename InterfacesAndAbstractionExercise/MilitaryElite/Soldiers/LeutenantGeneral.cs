using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Interface;

namespace MilitaryElite.Soldiers
{
    class LeutenantGeneral:Private,ILeutenantGeneral
    {
        private ICollection<ISoldier> privates;
        public LeutenantGeneral(int id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName, salary)
        {
           this.privates=new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => (IReadOnlyCollection<ISoldier>) this.privates;
        public void AddPrivate(ISoldier solder)
        {
            this.privates.Add(solder);
        }

        public override string ToString()
        {
            var sb=new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Privates:");
            foreach (var @private in Privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }
            var result = sb.ToString().TrimEnd();
            return result;
        }
    }
}
