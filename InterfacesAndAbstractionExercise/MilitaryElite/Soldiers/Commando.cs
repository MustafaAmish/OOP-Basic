using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MilitaryElite.Soldiers;

namespace MilitaryElite.Interface
{
    class Commando:SpecialisedSoldier,ICommando
    {
        private ICollection<IMission> missions;
        public Commando(int id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
            missions=new List<IMission>();
            
        }

        public IReadOnlyCollection<IMission> Missions =>(IReadOnlyCollection<IMission>) this.missions;

        public void AddMision(IMission mission)
        {
            missions.Add(mission);
        }

        public void MisionCompleate(string mision)
        {
            IMission mission = this.Missions.FirstOrDefault(x => x.CodeName == mision);
            mission.Complyte();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString())
                .AppendLine($"Corps: {this.Corps}")
                .AppendLine($"Missions:");
            foreach (var mission in Missions)
            {
                sb.AppendLine($"  {mission}");
            }
            var result = sb.ToString().TrimEnd();
            return result;
        }
    }
}
