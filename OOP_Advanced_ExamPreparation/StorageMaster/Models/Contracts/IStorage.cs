using System.Collections.Generic;

namespace StorageMaster.Models.Contracts
{
    public interface IStorage
    {
        //        •	Name – string
        //•	Capacity – int – the maximum weight of products the storage can handle
        //•	GarageSlots – int – the number of garage slots the storage’s garage has
        //•	IsFull – bool
        //o   Returns true if the sum of the products’ weights is equal to or larger than the storage capacity(calculated property)
        //•	Garage – IReadOnlyCollection of vehicles
        //o   Read-only representation of the garage array.
        //•	Products – IReadOnlyCollection of products

        IReadOnlyCollection<IVehicle> Garage { get; }

        IReadOnlyCollection<IProduct> Products { get; }

        string Name { get; }

        int Capacity { get; }

        int GarageSlots { get; }

        bool IsFull { get; }
    }
}
