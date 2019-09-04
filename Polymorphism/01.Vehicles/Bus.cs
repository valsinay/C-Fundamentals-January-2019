namespace _01.Vehicles
{
    public class Bus : Vehicle
    {
        public const double additionalConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption + additionalConsumption, tankCapacity)
        {
        }

        public string DriveEmpty(double distance)
        {
            this.FuelConsumption -= additionalConsumption;
           return base.Drive(distance);
        }
    }
}
