using _08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps,HashSet<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public HashSet<Mission> Missions { get;}

        public void CompleteMission(string codeName)
        {
            Mission mission = Missions
                .FirstOrDefault(x => x.CodeName == codeName);

            if (mission!=null)
            {
                mission.State = "Complete";
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine($"Missions:");

            foreach (var mission in this.Missions)
            {
                builder.AppendLine($"  {mission.ToString()}");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
