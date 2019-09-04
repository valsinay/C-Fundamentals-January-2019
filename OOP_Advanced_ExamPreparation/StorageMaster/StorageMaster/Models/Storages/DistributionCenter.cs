using StorageMaster.Models.Vehicles;

namespace StorageMaster.Models.Storages
{
    public class DistributionCenter : Storage
    {
        private const int defaultCapacity = 2;
        private const int defaultGarageSlots = 5;
        private static Vehicle[] defaultVehicles=
        {
            new Van(),
            new Van(),
            new Van()
        };

        public DistributionCenter (string name)
            : base(name, defaultCapacity, defaultGarageSlots, defaultVehicles)
        {
        }
    }
}
