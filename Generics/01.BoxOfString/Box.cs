using System;
using System.Collections.Generic;
using System.Text;

namespace _01.BoxOfString
{
    class Box<T>
    {  
        private T Value { get; set; }

        public Box(T value)
        {
            this.Value = value;
        }

        public override string ToString()
        {
            return $"{Value.GetType().FullName}: {Value}";
        }
    }
}
