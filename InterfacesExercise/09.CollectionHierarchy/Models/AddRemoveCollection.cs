using _09.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Models
{
    public class AddRemoveCollection<T> : AddCollection<T>, IAddRemoveCollection<T>
    {
        public T Remove()
        {
            throw new NotImplementedException();
        }
    }
}
