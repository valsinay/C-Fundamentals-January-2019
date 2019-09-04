using System;
using System.Collections.Generic;
using System.Linq;
using StorageMaster.Models.Contracts;
using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public abstract class Storage : IStorage
    {
        private Vehicle[] garage;
        private List<Product> products;
        private bool isFull;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<Vehicle> vehicles)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.GarageSlots = garageSlots;

            this.isFull = false;
            this.products = new List<Product>();
            this.garage = new Vehicle[this.GarageSlots];

            FillGarageSlotsWithVehicles(vehicles);
        }

        public IReadOnlyCollection<Vehicle> Garage => Array.AsReadOnly(this.garage);

        public IReadOnlyCollection<Product> Products => this.products.AsReadOnly();


        public string Name { get; private set; }

        public int Capacity { get; private set; }

        public int GarageSlots { get; private set; }

        public bool IsFull =>this.products.Sum(p => p.Weight) >= this.Capacity;
        
        public double TotalProductsPrice => this.products.Sum(p => p.Price);

        private void FillGarageSlotsWithVehicles(IEnumerable<Vehicle> vehicles)
        {
            int index = 0;

            foreach (var vehicle in vehicles)
            {
                this.garage[index] = vehicle;
                index++;
            }
        }

        public Vehicle GetVehicle(int garageSlot)
        {
            if (garageSlot >= this.GarageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if (this.garage[garageSlot] == null)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }
            Vehicle vehicle = this.garage[garageSlot];

            return vehicle;
        }


        public int SendVehicleTo(int garageSlot, Storage deliveryLocation)
        {
            Vehicle vehicle = this.GetVehicle(garageSlot);

            if (!deliveryLocation.garage.Any(x => x == null))
            {
                throw new InvalidOperationException("No room in garage!");
            }

            this.garage[garageSlot] = null;

            int newSlot = 0;

            for (int i = 0; i < deliveryLocation.garage.Length; i++)
            {
                if (deliveryLocation.garage[i] == null)
                {
                    newSlot = i;
                    break;
                }
            }

            deliveryLocation.garage[newSlot] = vehicle;

            return newSlot;
        }

        public int UnloadVehicle(int garageSlot)
        {

            if(IsFull)
            {
                throw new InvalidOperationException("Storage is full!");
            }

            Vehicle vehicle = this.GetVehicle(garageSlot);

            int unloadedProducts = 0;

            foreach (var product in vehicle.Trunk)
            {
                if (!vehicle.IsEmpty)
                {
                    if (!this.IsFull)
                    {
                        this.products.Add(product);
                        unloadedProducts++;
                    }
                }
            }

            return unloadedProducts;
        }
    }
}
