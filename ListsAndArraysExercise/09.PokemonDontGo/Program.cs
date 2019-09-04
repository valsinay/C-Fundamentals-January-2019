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

            while (input.Count > 0 )
            {
                int index = int.Parse(Console.ReadLine());

                if (index < 0)
                {
                    int firstElement = input.First();
                    int lastElement = input.Last();
                    input[0] = lastElement;
                    removedNums.Add(firstElement);

                    IncrementSequence(input, firstElement);
                }
                else if(index > input.Count - 1)
                {
                    int firstElement = input.First();
                    int lastElement = input.Last();
                    input[input.Count - 1] = firstElement;
                    removedNums.Add(lastElement);

                    IncrementSequence(input, lastElement);
                }
                else
                {
                    int removedElement = input[index];
                    input.RemoveAt(index);
                    removedNums.Add(removedElement);

                    IncrementSequence(input, removedElement);
                }
                
            }

            Console.WriteLine(string.Join(" ", removedNums.Sum()));
        }

        private static void IncrementSequence(List<int> input, int number)
        {
            for (int j = 0; j < input.Count; j++)
            {
                if (number >= input[j])
                {
                    input[j] += number;
                }
                else
                {
                    input[j] -= number;
                }
            }
        }
    }
}
