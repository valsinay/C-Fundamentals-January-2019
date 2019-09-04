using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvenOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = input[0];
            int end = input[1];

            string typeNumbers = Console.ReadLine();

            Predicate<int> filter = x => typeNumbers == "odd" ? x % 2 != 0 : x % 2 == 0;
            var numbers = new List<int>();

            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }
            Console.WriteLine(string.Join(" ",numbers.Where(x=>filter(x))));
        }
    }
}
