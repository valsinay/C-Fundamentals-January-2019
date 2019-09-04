using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.PlayAround
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = input[0];
            int elementsToPop = input[1];
            int searchedElement = input[2];

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(searchedElement))
            {
                Console.WriteLine("true");
            }
            else
            {
                int min = stack.Min();
                Console.WriteLine(min);
            }
        }
    }
}
