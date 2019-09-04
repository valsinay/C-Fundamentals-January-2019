using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Contracts
{
    public interface IMyList<T> : IAddRemoveCollection<T>
    {
        IReadOnlyCollection<T> Used { get; }
    }
}
