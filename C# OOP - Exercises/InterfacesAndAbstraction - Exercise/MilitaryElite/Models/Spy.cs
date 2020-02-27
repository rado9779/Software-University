using System.Text;

using MilitaryElite.Interfaces;

namespace MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(string id, string firstName, string lastName, int code)
         : base(id, firstName, lastName)
        {
            this.CodeNumber = code;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var builder = new StringBuilder();

            builder.AppendLine(base.ToString())
                .Append($"Code Number: {CodeNumber}");

            return builder.ToString();
        }
    }
}
