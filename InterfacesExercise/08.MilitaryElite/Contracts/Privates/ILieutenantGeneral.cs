using _08.MilitaryElite.Models;
using System.Collections.Generic;

namespace _08.MilitaryElite.Interfaces
{
    public interface ILieutenantGeneral
    {
        HashSet<Private> Privates { get; }
    }
}
