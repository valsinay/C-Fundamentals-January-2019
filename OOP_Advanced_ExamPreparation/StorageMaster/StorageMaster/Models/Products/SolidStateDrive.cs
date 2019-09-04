using StorageMaster.Models.Contracts;

namespace StorageMaster.Models.Products
{
    public class SolidStateDrive : Product
    {
        private const double constWeight = 0.2;

        public SolidStateDrive(double price)
            : base(price, constWeight)
        {
        }
    }
}
