using System.Collections.Generic;

namespace StorageMaster.Models.Contracts
{
    public interface IVehicle
    {
        // •	Capacity – int
        //•	Trunk – IReadOnlyCollection of Products
        //•	IsFull – bool
        //o   Returns true if the sum of the products’ weights is equal to or larger than the vehicle capacity(calculated property)
        //•	IsEmpty – bool

        IReadOnlyCollection<Product> Trunk { get; }

        int Capacity { get; }

        bool IsFull { get; }

        bool IsEmpty { get; }

        void LoadProduct(Product product);

        Product Unload();

    }
}
