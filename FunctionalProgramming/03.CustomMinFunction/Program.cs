using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split()
                .Select(int.Parse)
                .ToArray();
            Func<int[], int> print = c => input.Min();
            Console.WriteLine(print(input));
        }
    }
}
