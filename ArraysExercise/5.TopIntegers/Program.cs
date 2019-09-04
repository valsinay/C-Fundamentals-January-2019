using System;
using System.Linq;

namespace _5.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                int number = input[i];
                for (int j = i+1; j < input.Length; j++)
                {
                    int secNum = input[j];
                    if (number<=secNum)
                    {
                        break;
                    }
                    else if (j==input.Length-1)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
            Console.WriteLine(input[input.Length-1]);
        }
    }
}
