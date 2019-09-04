using System;
using System.Linq;

namespace _3.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] input = Console.ReadLine()
                    .Split()
                    .Select(decimal.Parse)
                    .ToArray();

            for (int i = 0; i <= input.Length-1; i++)
            {
                Console.WriteLine($"{input[i]} => {Math.Round(input[i],MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
