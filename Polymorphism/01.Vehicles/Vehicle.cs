using System;

namespace _01.Vehicles
{
    public abstract class Vehicle
    {
        private double fuelQuantity;

        public Vehicle(double fuelQuantity, double fuelConsumption, int tankCapacity)
        {
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get => this.fuelQuantity;

            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }
            }
        }

        public double FuelConsumption { get; protected set; }

        public int TankCapacity { get; private set; }

        public string Drive(double distance)
        {
            string vehicleName = this.GetType().Name;
            double neededFuel = this.FuelConsumption * distance;

            if (this.FuelQuantity >= neededFuel)
            {
                this.FuelQuantity -= neededFuel;

                return $"{vehicleName} travelled {distance} km";
            }
            else
            {
                return ($"{vehicleName} needs refueling");
            }
        }


        public virtual double Refuel(double refuelQuantity)
        {
            if (refuelQuantity <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (this.fuelQuantity + refuelQuantity > this.TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {refuelQuantity} fuel in the tank");
            }
            return this.FuelQuantity += refuelQuantity;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }

    }
}
