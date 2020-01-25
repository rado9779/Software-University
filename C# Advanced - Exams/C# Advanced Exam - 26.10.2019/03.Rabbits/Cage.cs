using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Rabbits
{
    public class Cage
    {
        private List<Rabbit> data;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.data = new List<Rabbit>();
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => this.data.Count();

        public void Add(Rabbit rabbit)
        {
            if (this.data.Count < this.Capacity)
            {
                this.data.Add(rabbit);
            }
        }
        public bool RemoveRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(x => x.Name == name);

            if (rabbit != null)
            {
                this.data.Remove(rabbit);
                return true;
            }
            return false;
        }
        public void RemoveSpecies(string species)
        {
            this.data.RemoveAll(x => x.Species == species);
        }
        public Rabbit SellRabbit(string name)
        {
            Rabbit rabbit = this.data.FirstOrDefault(x => x.Name == name);
            rabbit.Available = false;
            return rabbit;
        }
        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            List<Rabbit> rabbits = this.data.FindAll(x => x.Species == species);
            rabbits.ForEach(x => x.Available = false);
            return rabbits.ToArray();
        }
        public string Report()
        {
            List<Rabbit> rabbits = this.data.FindAll(x => x.Available == true);
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Rabbits available at {this.Name}:");
            foreach (var rabbit in rabbits)
            {
                sb.AppendLine(rabbit.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
