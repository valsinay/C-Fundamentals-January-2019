using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            Console.ReadLine()
             .Split()
             .Where(x => x.Length <= length)
             .ToList()
             .ForEach(Console.WriteLine);
        }
    }
}
