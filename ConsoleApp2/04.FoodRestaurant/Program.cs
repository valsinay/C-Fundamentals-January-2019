using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FoodRestaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            var input = Console.ReadLine()
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Queue<int> queue = new Queue<int>(input);

            int maxOrder = queue.Max();
            Console.WriteLine(maxOrder);

            if (foodQuantity <= 0 && queue.Count > 0)
            {
                Console.Write($"Orders left: ");
                Console.Write(string.Join(" ", queue));
                Console.WriteLine();
                return;
            }
            while (foodQuantity-queue.Peek() >=0 )
            {
                if (queue.Count > 0)
                {
                    
                    foodQuantity -= queue.Dequeue();
                }
                if (queue.Count == 0)
                {
                    Console.WriteLine("Orders complete");
                    return;
                }
            }
                Console.Write($"Orders left: ");
                Console.WriteLine(string.Join(" ", queue));
        }
    }
}