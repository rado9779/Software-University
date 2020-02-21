using System;
using System.Linq;
using System.Collections.Generic;

using _05.FootballTeamGenerator.Utilities;

namespace _05.FootballTeamGenerator.Models
{
    public class Team
    {
        private string name;
        private readonly List<Player> players;

        public Team(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
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
        public IReadOnlyCollection<Player> Players => this.players.AsReadOnly();

        public void AddPlayer(Player player)
        {
            if (player != null)
            {
                this.players.Add(player);
            }
        }

        public void RemovePlayer(string playerName)
        {
            if (!this.players.Any(p => p.Name == playerName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RemoveMissingPlayer,playerName,this.Name));
            }
            Player pl = this.players.FirstOrDefault(p => p.Name == playerName);
            this.players.Remove(pl);
        }
    }
}
