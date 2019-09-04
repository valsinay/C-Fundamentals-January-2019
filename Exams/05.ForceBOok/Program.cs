using System;
using System.Collections.Generic;

namespace _05.ForceBOok
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            while (true)
            {
                string line = Console.ReadLine();

                if (line== "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains("|"))
                {
                    string[] tokens = line.Split(" | ");

                    string side = tokens[0];
                    string name = tokens[1];

                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, side);
                    }
                    
                }
                else
                {
                    string[] tokens = line.Split(" -> ");

                    string name = tokens[0];
                    string side = tokens[1];
                    if (users.ContainsKey(name))
                    {
                        users[name] = side;
                    }
                    else
                    {
                        users[name] = side;
                    }
                    Console.WriteLine($"{name} joins the {side} side!");
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"Side:{item.Value});
            }
        }
    }
}
