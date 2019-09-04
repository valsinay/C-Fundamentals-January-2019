using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            if (!(input.Contains(')') || input.Contains('(') || input.Contains('{')
                || input.Contains('}') || input.Contains('[') || input.Contains(']')))
            {
                Console.WriteLine("NO");
                return;
            }
            if (input.Length == 1 && input.Length >1000)
            {
                Console.WriteLine("NO");
                return;
            }
            for (int i = 0; i < input.Length / 2; i++)
            {
                queue.Enqueue(input[i]);
            }
            for (int i = input.Length / 2; i < input.Length; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < input.Length / 2; i++)
            {
                var firstElement = queue.Dequeue();
                var secondElement = stack.Pop();

                if (firstElement == '[' && secondElement == ']'
                    || firstElement == '{' && secondElement == '}'
                    || firstElement == '(' && secondElement == ')'
                    || firstElement == ' ' && secondElement == ' ')
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }

            }
            Console.WriteLine("YES");

        }
    }
}
