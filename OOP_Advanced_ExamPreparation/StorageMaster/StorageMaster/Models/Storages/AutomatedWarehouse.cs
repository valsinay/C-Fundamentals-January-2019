using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class AutomatedWarehouse : Storage
    {
        private const int defaultCapacity = 1;
        private const int defaultGarageSlots = 2;
        private static Vehicle[] defaultVehicles =
        {
            new Truck()
            
        };

        public AutomatedWarehouse(string name)
            : base(name, defaultCapacity, defaultGarageSlots, defaultVehicles)
        {
        }
    }
}
