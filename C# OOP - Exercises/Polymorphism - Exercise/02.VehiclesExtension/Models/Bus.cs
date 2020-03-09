namespace _02.VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double additionalConsumptionPerKm = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
            this.FuelConsumption += additionalConsumptionPerKm;
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= additionalConsumptionPerKm;
            return base.Drive(distance);
        }
    }
}
