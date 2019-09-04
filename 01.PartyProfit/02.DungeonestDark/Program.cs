using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.DungeonestDark
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> rooms = Console.ReadLine()
                .Split(new string[] { "|" }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int health = 100;
            int coins = 0;

            for (int i = 0; i <= rooms.Count - 1; i++)
            {
                List<string> splittedEvents = rooms[i].Split(" ")
                    .ToList();

                int index = rooms.IndexOf(rooms[i]);

                string command = splittedEvents[0];
                int number = int.Parse(splittedEvents[1]);

                if (command == "potion")
                {
                    int count = 0;
                    if (health == 100)
                    {
                        continue;
                    }
                    else if (health + number<=100)
                    {
                        health += number;
                        Console.WriteLine($"You healed for {number} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                    else
                    {
                        for (int j = health; j < 100; j++)
                        {
                             
                            health++;
                            count++;
                        }
                        Console.WriteLine($"You healed for {count} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }
                   

                }
                else if (command == "chest")
                {
                    coins += number;
                    Console.WriteLine($"You found {number} coins.");
                }
                else
                {
                    if (health > number)
                    {
                        health -= number;
                        Console.WriteLine($"You slayed { command}.");
                    }
                    else if (health - number <= 0 || health <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {index+1}");
                        return;
                    }

                }
            }

            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");

        }
    }
}
