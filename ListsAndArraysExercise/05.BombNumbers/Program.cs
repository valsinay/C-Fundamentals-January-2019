using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> properties = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int bomb = properties[0];
            int power = properties[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {

                    int startIndex = i - power;
                    int endIndex = i + power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (startIndex > numbers.Count-1 || endIndex<0)
                    {
                        continue;
                    }
                    if (endIndex > numbers.Count-1)
                    {
                        endIndex=numbers.Count-1;
                    }
                    numbers.RemoveRange(startIndex, endIndex - startIndex + 1);

                    i=startIndex - 1;
                }
            }
            int sum = numbers.Sum();
            Console.WriteLine(sum);

        }
    }
}
