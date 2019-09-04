using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Contracts
{
    public interface IAddRemoveCollection<T> : IAddCollection<T>
    {
        T Remove();
    }
}
