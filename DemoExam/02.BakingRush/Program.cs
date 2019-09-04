using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BakingRush
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> events = Console.ReadLine()
                .Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int coins = 100;
            int energy = 100;

            var newList = new List<string>();

            for (int i = 0; i < events.Count; i++)
            {
                List<string> splittedEvents = events[i].Split("-").ToList();

                string command = splittedEvents[0];
                int number = int.Parse(splittedEvents[1]);

                if (command == "rest")
                {
                    if (energy >= 100)
                    {
                        Console.WriteLine("You gained 0 energy.");
                        Console.WriteLine("Current energy: 100.");
                    }
                    else if (energy + number < 100)
                    {
                        energy += number;
                        Console.WriteLine($"You gained {number} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                    }
                }
                else if (command == "order")
                {
                    if (energy >= 30)
                    {
                        energy -= 30;
                        coins += number;
                        Console.WriteLine($"You earned {number} coins.");
                    }
                    else
                    {
                        energy += 50;
                        Console.WriteLine("You had to rest!");
                        continue;
                    }
                }
                else
                {
                    if ( coins > number)
                    {
                        coins -= number;
                        Console.WriteLine($"You bought {command}.");

                    }
                    else if (coins-number <=0 || coins <=0)
                    {
                        Console.WriteLine($"Closed! Cannot afford {command}.");
                        return;
                    }
                }
            }
            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
