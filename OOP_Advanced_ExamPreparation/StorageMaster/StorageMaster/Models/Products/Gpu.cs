using StorageMaster.Models.Contracts;

namespace StorageMaster.Models.Products
{
    public class Gpu : Product
    {
        private const double constWeight = 0.7;

        public Gpu(double price) 
            : base(price, constWeight)
        {
        }
    }
}
