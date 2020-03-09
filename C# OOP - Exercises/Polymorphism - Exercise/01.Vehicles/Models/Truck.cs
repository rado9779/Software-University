namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double additionalConsumptionPerKm = 1.6;
        private const double refuelingIndex = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {

        }

        protected override double AdditionalConsumption => additionalConsumptionPerKm;

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * refuelingIndex);
        }
    }
}
