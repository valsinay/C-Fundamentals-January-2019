using _08.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08.MilitaryElite.Models.Privates
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, HashSet<Private> privates)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = privates;
        }

        public HashSet<Private> Privates { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .AppendLine("Privates:");

            foreach (var @private in this.Privates)
            {
                builder.AppendLine($"  {@private.ToString()}");
            }

            return builder.ToString().TrimEnd();
        }
    }
}
