using System;
using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethod
{
    public class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }
        public List<T> Data
        {
            get
            {
                return this.data;
            }
        }

        public void Add(T item)
        {
            this.data.Add(item);
        }

        public override string ToString()
        {
            return $"{this.data.GetType().FullName}: {this.data}";
        }

    }
}
