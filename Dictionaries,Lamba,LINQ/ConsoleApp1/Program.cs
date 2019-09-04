using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonDontGo
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();

                string command = tokens[0];
                string name = tokens[1];
               

                if (command == "register")
                {
                    string licensePlateNumber = tokens[2];
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                    else if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number { licensePlateNumber}");
                    }

                }
                else if (command == "unregister")
                {
                    if (!users.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else if (users.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        users.Remove(name);
                    }
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}