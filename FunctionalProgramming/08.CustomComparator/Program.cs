using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x % 2 == 0)
                .ThenBy(x => x % 2 != 0)
                .ToList()
                .ForEach(x => Console.Write(x + " "));
        }
    }
}
