using System;
using System.Linq;

namespace _7.MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int currentSeq = 1;
            int maxSeq = 1;
            int number = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    currentSeq++;

                    if (currentSeq > maxSeq)
                    {
                        number = numbers[i];
                        maxSeq = currentSeq;
                    }
                }
                else
                {
                    currentSeq = 1;
                }
            }
            for (int i = 0; i < maxSeq; i++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}