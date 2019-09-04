using System;
using System.Linq;

namespace _6.EvenOddSubstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                int currentNum = input[i];
                if (currentNum % 2 == 0)
                {
                    sumEven += currentNum;
                }
                else
                {
                    sumOdd += currentNum;
                }
                
            }
            result = sumEven - sumOdd;
            Console.WriteLine(result);
            
        }
    }
}
