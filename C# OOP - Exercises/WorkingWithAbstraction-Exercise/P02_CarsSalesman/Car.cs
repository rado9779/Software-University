using System.Text;

namespace P02_CarsSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int? weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
        }

        public Car(string model, Engine engine, int? weight)
            : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.Color = color;
        }

        public Car(string model, Engine engine, int? weight, string color)
            : this(model, engine)
        {
            this.weight = weight;
            this.Color = color;
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
        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            private set
            {
                this.engine = value;
            }
        }
        public string Color
        {
            get
            {
                return this.color;
            }
            private set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.AppendLine($"{this.Model}:");
            builder.Append(this.Engine);
            builder.AppendLine($"  Weight: {(this.weight == null ? "n/a" : this.weight.ToString())}");
            builder.Append($"  Color: {(this.Color == null ? "n/a" : this.Color)}");

            return builder.ToString();
        }
    }
}
