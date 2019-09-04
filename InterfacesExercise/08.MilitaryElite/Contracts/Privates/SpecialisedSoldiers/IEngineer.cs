using _08.MilitaryElite.Models.Privates.SpecialisedSoldiers;
using System.Collections.Generic;

namespace _08.MilitaryElite.Contracts.Privates.SpecialisedSoldiers
{
    public interface IEngineer
    {
        HashSet<Repair> Repairs { get; }
    }
}
