using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Socks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] leftSocks = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] rightSocks = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Stack<int> left = new Stack<int>(leftSocks);

            Queue<int> right = new Queue<int>(rightSocks);

            List<int> pairs = new List<int>();

            while (left.Count>0 && right.Count >0)
            {
                int leftSock = left.Peek();
                int rightSock = right.Peek();

                if (leftSock == rightSock)
                {
                    right.Dequeue();
                    left.Pop();
                    left.Push(leftSock += 1);
                }
                else if (rightSock > leftSock)
                {
                    left.Pop();
                }
                else 
                {
                    int sum = 0;
                    sum= leftSock + rightSock;
                    pairs.Add(sum);
                    left.Pop();
                    right.Dequeue();
                }
            }
                Console.WriteLine(pairs.Max());
                Console.WriteLine(string.Join(" ",pairs));
        }
    }
}
