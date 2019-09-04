using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            List<int> removedNums = new List<int>();

            while (input.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstElement = input.First();
                    int lastElement = input.Last();
                    input[0] = lastElement;
                    removedNums.Add(firstElement);

                    Removing(input, firstElement);
                }
                else if (index > input.Count - 1)
                {
                    int lastElement = input.Last();
                    int firstElement = input.First();
                    input[input.Count - 1] = firstElement;
                    removedNums.Add(lastElement);

                    Removing(input, lastElement);
                }
                else
                {
                    int num = input[index];
                    input.RemoveAt(index);
                    removedNums.Add(num);

                    Removing(input, num);
                }
            }
            Console.WriteLine(string.Join(" ", removedNums.Sum()));
        }
        private static void Removing(List<int> input, int element)
        {
            for (int m = 0; m < input.Count; m++)
            {
                if (element >= input[m])
                {
                    input[m] += element;
                }
                else
                {
                    input[m] -= element;
                }
            }
        }
    }
}
