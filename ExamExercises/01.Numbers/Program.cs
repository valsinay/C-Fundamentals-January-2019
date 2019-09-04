using System;
using System.Linq;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            double average = input.Average();

            double[] numbers = new double[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > average)
                {
                    numbers[i] = input[i];

                }
            }
            if (input.Length == 1 || input.Any(x=>x==average))
            {
                Console.WriteLine("No");
                
            }
            else 
            {
                Console.WriteLine(string.Join(" ", numbers.OrderByDescending(x => x).Where(x => x != 0).Take(5)));
            }
            

        }
    }
}
