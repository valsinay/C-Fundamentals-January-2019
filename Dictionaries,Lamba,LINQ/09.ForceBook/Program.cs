using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Lumpawaroo")
                {
                    break;
                }
                string[] tokens = new string[0];
                if (line.Contains("|"))
                {
                    tokens = line.Split(" | ");

                    string side = tokens[0];
                    string name = tokens[1];

                    if (!users.ContainsKey(name))
                    {
                        users[name] = side;
                    }
                }
                else
                {
                    tokens = line.Split(" -> ");

                    string name = tokens[0];
                    string side = tokens[1];

                    if (users.ContainsKey(name))
                    {
                        users[name] = side;
                    }
                    else if (!users.ContainsKey(name))
                    {
                        users[name] = side;

                        Console.WriteLine($"{name} joins the {side} side!");
                    }
                }
            
            }
            foreach (var item in users)
            {
                Console.WriteLine($" Side: { item.Key}, Members: { item.Value}");
            }
        }
    }
}
