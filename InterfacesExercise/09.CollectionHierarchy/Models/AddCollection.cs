using _09.CollectionHierarchy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _09.CollectionHierarchy.Models
{
    public class AddCollection<T> : IAddCollection<T>
    {
        public AddCollection()
        {
            this.Data = new Stack<T>();
        }

        protected Stack<T> Data { get; set; }

        public virtual int Add(T element)
        {
            this.Data.Push(element);
            return this.Data.Count - 1;
        }
    }
}
