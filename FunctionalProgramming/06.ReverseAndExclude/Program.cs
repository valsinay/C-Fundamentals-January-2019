using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Reverse()
                .ToList();

            int divisible = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> func = x => x.Where(a => a % divisible != 0).ToList();
            numbers = func(numbers);
            
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
