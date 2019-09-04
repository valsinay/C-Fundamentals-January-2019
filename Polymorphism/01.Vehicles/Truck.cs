using System;

namespace _01.Vehicles
{
    public class Truck : Vehicle
    {
        private const double additionalConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption, int tankCapacity) 
            : base(fuelQuantity, fuelConsumption+additionalConsumption , tankCapacity)
        {
        }

        public override double Refuel(double refuelQuantity)
        {
             base.Refuel(refuelQuantity);
            return this.FuelQuantity -= refuelQuantity * 0.05;
        }
    }
}
