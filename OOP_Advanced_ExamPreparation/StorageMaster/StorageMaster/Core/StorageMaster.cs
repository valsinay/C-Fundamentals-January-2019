using StorageMaster.Factories;
using StorageMaster.Models.Contracts;
using StorageMaster.Models.Storages;
using StorageMaster.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Core
{
    public class StorageMaster
    {
        private ProductFactory productFactory;
        private VehicleFactory vehicleFactory;
        private StorageFactory storageFactory;

        private Vehicle vehicle;
        private List<Product> products;
        private List<Storage> storages;

        public StorageMaster()
        {
            this.productFactory = new ProductFactory();
            this.storageFactory = new StorageFactory();
            this.vehicleFactory = new VehicleFactory();
            this.products = new List<Product>();
            this.storages = new List<Storage>();
        }


        public string AddProduct(string type, double price)
        {
            Product product = this.productFactory.CreateProduct(type, price);
            this.products.Add(product);

            return $"Added {type} to pool";
        }

        public string RegisterStorage(string type, string name)
        {
            Storage storage = this.storageFactory.CreateStorage(type, name);
            this.storages.Add(storage);

            return $"Registered {name}";
        }

        public string SelectVehicle(string storageName, int garageSlot)
        {
            Storage storage = storages.FirstOrDefault(x => x.Name == storageName);
            vehicle = storage.GetVehicle(garageSlot);

            return $"Selected {vehicle.GetType().Name}";
        }

        public string LoadVehicle(IEnumerable<string> productNames)
        {
            foreach (var name in productNames)
            {
                var product = this.products.FirstOrDefault(x => x.GetType().Name == name);

                if (product == null)
                {
                    throw new InvalidOperationException($"{name} is out of stock!");
                }

                product = this.products.Last(x => x.GetType().Name == name);

                if (this.vehicle.IsFull)
                {

                    return $"Loaded {vehicle.Trunk.Count}/{productNames.Count()} products into {this.vehicle.GetType().Name}";
                }
                products.Remove(product);
                this.vehicle.LoadProduct(product);
            }
            return $"Loaded {vehicle.Trunk.Count}/{productNames.Count()} products into {this.vehicle.GetType().Name}";

        }

        public string SendVehicleTo(string sourceName, int sourceGarageSlot, string destinationName)
        {
            Storage sourceStorage = storages.FirstOrDefault(x => x.Name == sourceName);
            if (sourceStorage == null)
            {
                throw new InvalidOperationException("Invalid source storage!");
            }
            vehicle = sourceStorage.GetVehicle(sourceGarageSlot);

            Storage destinationStorage = storages.FirstOrDefault(x => x.Name == destinationName);
            if (destinationStorage == null)
            {
                throw new InvalidOperationException("Invalid destination storage!");

            }
            int slot = -1;

            foreach (var item in destinationStorage.Garage)
            {
                if (item == null)
                {
                    slot = sourceStorage.SendVehicleTo(sourceGarageSlot, destinationStorage);
                    break;
                }
            }
            return $"Sent {vehicle.GetType().Name} to {destinationName} (slot {slot})";
        }

        public string UnloadVehicle(string storageName, int garageSlot)
        {
            Storage storage = this.storages.FirstOrDefault(x => x.Name == storageName);
            vehicle = storage.GetVehicle(garageSlot);

            int unloadedProducts = storage.UnloadVehicle(garageSlot);

            return $"Unloaded {unloadedProducts}/{vehicle.Trunk.Count} products at {storageName}";
        }

        public string GetStorageStatus(string storageName)
        {
            var builder = new StringBuilder();

            Storage storage = storages.FirstOrDefault(x => x.Name == storageName);

            double weight = storage.Products.Sum(x => x.Weight);

            var sortedProducts = storage.Products
                .GroupBy(x => x.GetType().Name)
                    .Select(x => new
                    {
                        Name = x.Key,
                        Count = x.Count()
                    })
                    .ToList();

            List<string> sortedProductsToString = new List<string>();

            foreach (var product in sortedProducts.OrderByDescending(p => p.Count).ThenBy(x => x.Name))
            {
                sortedProductsToString.Add($"{product.Name} ({product.Count})");
            }

            builder.AppendLine($"Stock ({weight}/{storage.Capacity}): [{string.Join(", ", sortedProductsToString)}]");

            List<string> vehiclesInGarage = new List<string>();

            foreach (var vehicle in storage.Garage)
            {
                if (vehicle == null)
                {
                    vehiclesInGarage.Add("empty");
                }
                else
                {
                    vehiclesInGarage.Add(vehicle.GetType().Name);
                }
            }

            builder.AppendLine($"Garage: [{string.Join("|", vehiclesInGarage)}]");

            return builder.ToString().TrimEnd();
        }

        public string GetSummary()
        {
            var builder = new StringBuilder();

            foreach (Storage item in this.storages.OrderByDescending(x => x.Products.Sum(y => y.Price)))
            {
                double total = item.TotalProductsPrice;

                builder.AppendLine($"{item.Name}:")
                    .AppendLine($"Storage worth: ${total:f2}");
            }
            return builder.ToString().TrimEnd();
        }
    }
}
