using System;

using _05.FootballTeamGenerator.Utilities;

namespace _05.FootballTeamGenerator.Models
{
    public class Player
    {
        private string name;

        public Player(string name, Stat stats)
        {
            this.Name = name;
            this.Stats = stats;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidName);
                }

                this.name = value;
            }
        }

        public Stat Stats { get; private set; }

        public double PlayerSkilllevel()
        {
            double level = this.Stats.TotalStats() / 5.0;
            return level;
        }
    }

}
