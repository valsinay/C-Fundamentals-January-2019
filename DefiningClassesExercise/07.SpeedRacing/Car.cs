using System;
using System.Collections.Generic;
using System.Text;

namespace _07.SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumption;
        private double distance = 0;

        public Car(string model, double fuelAmount, double fuelConsumption, double distance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumption;
            this.Distance = distance;
        }

        public bool Travelling(double distance)
        {
            return distance * fuelConsumption <= fuelAmount;
            
        }
        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }
        public double FuelAmount
        {
            get { return this.fuelAmount; }
            set { this.fuelAmount = value; }
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public double Distance
        {
            get { return this.distance; }
            set { this.distance = value; }
        }

    }
}
