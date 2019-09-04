using System;
using System.Collections.Generic;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < input.Length / 2; i++)
            {
                char element = input[i];
                if (element == '{' || element == '[' ||element== '{')
                {
                    stack.Push(element);
                }
            }

        }
    }
}
