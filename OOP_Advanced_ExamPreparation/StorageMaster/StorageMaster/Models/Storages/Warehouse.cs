using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class Warehouse : Storage
    {
        private const int defaultCapacity = 10;
        private const int defaultGarageSlots = 10;
        private static Vehicle[] defaultVehicles =
        {
            new Semi(),
            new Semi(),
            new Semi()
        };
        public Warehouse(string name)
            : base(name, defaultCapacity, defaultGarageSlots, defaultVehicles)
        {
        }
    }
}
