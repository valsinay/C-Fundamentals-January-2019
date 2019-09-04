
using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumMinimum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToArray();

                int num = line[0];
                
                if (num== 1)
                {
                    int element = line[1];
                    stack.Push(element);
                }
                else if (num == 2)
                {
                    stack.Pop();
                }
                else if (num == 3 && stack.Count>0)
                {
                    int max = stack.Max();
                    Console.WriteLine(max);
                }
                else if(num == 4 && stack.Count>0)
                {
                    int min = stack.Min();
                    Console.WriteLine(min);
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
