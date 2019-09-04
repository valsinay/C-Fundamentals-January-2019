namespace StorageMaster.Models.Vehicles
{
    public class Truck : Vehicle
    {
        private const int initialCapacity = 5;

        public Truck()
            : base(initialCapacity)
        {
        }
    }
}
