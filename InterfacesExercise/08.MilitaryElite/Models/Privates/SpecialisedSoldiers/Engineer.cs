using _08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Models.Privates.SpecialisedSoldiers
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps,HashSet<Repair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Repairs = repairs;
        }

        public HashSet<Repair> Repairs { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString());
            builder.AppendLine($"Repairs:");

            foreach (var repair in this.Repairs)
            {
                builder.AppendLine($"  {repair.ToString()}");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
