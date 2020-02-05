using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private string model;
        private int power;
        private int? displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
        }

        public Engine(string model, int power, int? displacement)
            : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.Efficiency = efficiency;
        }

        public Engine(string model, int power, int? displacement, string efficiency)
            : this(model, power)
        {
            this.displacement = displacement;
            this.Efficiency = efficiency;
        }

        public string Model
        {
            get 
            { 
                return this.model;
            }
            private set 
            {
                this.model = value;
            }
        }
        public int Power
        {
            get 
            {
                return this.power;
            }
            private set
            {
                this.power = value;
            }
        }
        public string Efficiency
        {
            get
            {
                return this.efficiency;
            }
            private set
            {
                this.efficiency = value;
            }
        }
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"  {this.Model}:");
            builder.AppendLine($"    Power: {this.Power}");
            builder.AppendLine($"    Displacement: {(this.displacement == null ? "n/a" : this.displacement.ToString())}");
            builder.AppendLine($"    Efficiency: {(this.Efficiency == null ? "n/a" : this.Efficiency.ToString())}");

            return builder.ToString();
        }
    }
}
