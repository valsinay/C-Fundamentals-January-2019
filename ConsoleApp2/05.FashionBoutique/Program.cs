using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int capacity = int.Parse(Console.ReadLine());
            int racks = 1;
            int sum = 0;

            Stack<int> clothesValue = new Stack<int>(input);

            while (clothesValue.Any())
            {
                if (sum + clothesValue.Peek() <=capacity)
                {
                    sum += clothesValue.Pop();
                }
                else
                {
                    sum = 0;
                    racks++;
                }

            }

            Console.WriteLine(racks);
        }
    }
}
