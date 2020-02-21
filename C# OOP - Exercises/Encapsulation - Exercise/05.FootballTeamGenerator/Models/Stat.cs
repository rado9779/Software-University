using System;

using _05.FootballTeamGenerator.Utilities;

namespace _05.FootballTeamGenerator.Models
{
    public class Stat
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

        public Stat(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
        }


        public int Endurance
        {
            get
            {
                return this.endurance;
            }
            private set
            {
                if (value < Constants.statMinValue || value > Constants.statMaxValue)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidStat, nameof(Endurance)));
                }

                this.endurance = value;
            }
        }
        public int Sprint
        {
            get
            {
                return this.sprint;
            }
            private set
            {
                if (value < Constants.statMinValue || value > Constants.statMaxValue)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidStat, nameof(Sprint)));
                }

                this.sprint = value;
            }
        }
        public int Dribble
        {
            get
            {
                return this.dribble;
            }
            private set
            {
                if (value < Constants.statMinValue || value > Constants.statMaxValue)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidStat, nameof(Dribble)));
                }

                this.dribble = value;
            }
        }

        public int Passing
        {
            get
            {
                return this.passing;
            }

            private set
            {
                if (value < Constants.statMinValue || value > Constants.statMaxValue)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidStat, nameof(Passing)));
                }

                this.passing = value;
            }
        }
        public int Shooting
        {
            get
            {
                return this.shooting;
            }
            private set
            {
                if (value < Constants.statMinValue || value > Constants.statMaxValue)
                {
                    throw new ArgumentException(
                        string.Format(ExceptionMessages.InvalidStat, nameof(Shooting)));
                }

                this.shooting = value;
            }
        }
        public int TotalStats()
        {
            int sum = this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting;
            return sum;
        }
    }
}
