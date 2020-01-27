using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> data;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Astronaut>();
        }
        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count();

        public void Add(Astronaut astronaut)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(astronaut);
            }
        }
        public bool Remove(string name)
        {
            Astronaut astronaut = this.data.FirstOrDefault(x => x.Name == name);

            if (astronaut != null)
            {
                this.data.Remove(astronaut);
                return true;
            }
            return false;
        }
        public Astronaut GetOldestAstronaut()
        {
            Astronaut oldestAstronaut = this.data
                .OrderByDescending(x => x.Age)
                .FirstOrDefault();

            if (oldestAstronaut != null)
            {
                return oldestAstronaut;
            }
            return null;
        }
        public Astronaut GetAstronaut(string name)
        {
            Astronaut astronaut = this.data.FirstOrDefault(x => x.Name == name);

            if (astronaut != null)
            {
                return astronaut;
            }
            return null;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Astronauts working at Space Station {this.Name}:");

            foreach (var astronaut in this.data)
            {
                sb.AppendLine(astronaut.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
