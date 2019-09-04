using StorageMaster.Models.Contracts;

namespace StorageMaster.Models.Products
{
    public class HardDrive:Product
    {
        private const double constWeight = 1;

        public HardDrive(double price)
            : base(price, constWeight)
        {
        }
    }
}
