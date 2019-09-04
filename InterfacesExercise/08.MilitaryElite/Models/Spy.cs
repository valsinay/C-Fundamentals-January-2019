using _08.MilitaryElite.Interfaces;
using System.Text;

namespace _08.MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int spyCode) 
            : base(id, firstName, lastName)
        {
            this.SpyCodeNumber = spyCode;
        }

        public int SpyCodeNumber { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(base.ToString())
                .AppendLine($"Code Number: {this.SpyCodeNumber}");

            return builder.ToString().Trim();
        }
    }
}
