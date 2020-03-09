namespace _02.VehiclesExtension
{
    public class Truck : Vehicle
    {
        private const double additionalConsumptionPerKm  = 1.6;
        private const double refuelingIndex = 0.05;

        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += additionalConsumptionPerKm ;
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel);
            this.FuelQuantity -= fuel * refuelingIndex;
        }
    }
}
