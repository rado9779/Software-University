using System.Collections.Generic;
using System.Linq;

namespace FightingArena
{
    public class Arena
    {
        private List<Gladiator> gladiators;

        public Arena(string name)
        {
            this.Name = name;
            this.gladiators = new List<Gladiator>();
        }
        public string Name { get; set; }


        public int Count => this.gladiators.Count();

        public void Add(Gladiator gladiator)
        {
            if (gladiators.Contains(gladiator) == false)
            {
                this.gladiators.Add(gladiator);
            }
        }
        public void Remove(string name)
        {
            Gladiator gladiator = this.gladiators.FirstOrDefault(x => x.Name == name);

            if (gladiator != null)
            {
                this.gladiators.Remove(gladiator);
            }
        }
        public Gladiator GetGladitorWithHighestStatPower()
        {
            Gladiator gladiator = this.gladiators
                .OrderByDescending(x => x.GetStatPower())
                .FirstOrDefault();

            if (gladiator != null)
            {
                return gladiator;
            }
            return null;
        }
        public Gladiator GetGladitorWithHighestWeaponPower()
        {
            Gladiator gladiator = this.gladiators
                .OrderByDescending(x => x.GetWeaponPower())
                .FirstOrDefault();

            if (gladiator != null)
            {
                return gladiator;
            }
            return null;
        }
        public Gladiator GetGladitorWithHighestTotalPower()
        {
            Gladiator gladiator = this.gladiators
                .OrderByDescending(x => x.GetTotalPower())
                .FirstOrDefault();

            if (gladiator != null)
            {
                return gladiator;
            }
            return null;
        }
        public override string ToString()
        {
            return $"[{this.Name}] - [{this.Count}] gladiators are participating.";
        }

    }
}
