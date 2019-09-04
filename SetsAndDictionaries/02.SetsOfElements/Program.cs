using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sum = input[0] + input[1];
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            HashSet<int> final = new HashSet<int>();

            for (int i = 0; i < sum; i++)
            {
                int numbers = int.Parse(Console.ReadLine());

                if (i < input[0])
                {
                    firstSet.Add(numbers);
                }
                else
                {
                    secondSet.Add(numbers);
                }
            }
            foreach (var first in firstSet)
            {
                foreach (var second in secondSet)
                {
                    if (first == second)
                    {
                        final.Add(first);
                    }
                }
            }
            foreach (var item in final)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
