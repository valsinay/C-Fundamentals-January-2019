using System;
using System.Collections.Generic;
using System.Linq;


namespace StorageMaster.Models.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private bool isFull;
        private bool isEmpty;
        private int capacity;
        private List<Product> trunk;

        protected Vehicle(int capacity)
        {
            this.trunk = new List<Product>();
            this.IsFull = isFull;
            this.IsEmpty = isEmpty;
            this.Capacity = capacity;
        }


        public bool IsFull
        {
            get => this.isFull;

            private set
            {
                if (this.capacity <= Trunk.Select(x => x.Weight).Sum())
                {
                    this.isFull = true;
                }
                this.isFull = false;
            }
        }

        public bool IsEmpty
        {
            get => this.isEmpty;

            private set
            {
                if (Trunk.Count == 0)
                {
                    this.isEmpty = true;
                }
                this.isEmpty = false;
            }
        }

        public int Capacity { get; set; }

        public IReadOnlyCollection<Product> Trunk => this.trunk.AsReadOnly();

        public void LoadProduct(Product product)
        {
            if (isFull == true)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }

            trunk.Add(product);
        }

        public Product Unload()
        {
            if (isEmpty==true)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }

            var product = this.trunk.Last();
            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;

        }
    }
}
