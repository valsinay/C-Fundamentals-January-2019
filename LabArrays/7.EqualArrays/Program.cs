using System;
using System.Linq;

namespace _7.EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArray = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();
            

            int sum = 0;


            for (int i = 0; i < firstArray.Length; i++)
            {
                int index = Array.IndexOf(secondArray, secondArray[i]);

                if (firstArray[i] != secondArray[i])

                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
                    return;
                }
                sum += firstArray[i];

            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
