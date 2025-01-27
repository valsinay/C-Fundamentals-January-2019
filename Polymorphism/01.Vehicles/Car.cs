﻿using System;

namespace _01.Vehicles
{
    public class Car : Vehicle
    {
        private const double additionalConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, int tankCapacity)
            : base(fuelQuantity, fuelConsumption + additionalConsumption, tankCapacity)
        {
        }
    }
}
