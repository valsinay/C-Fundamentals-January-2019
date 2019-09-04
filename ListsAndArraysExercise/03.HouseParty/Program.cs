using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                string[] input = line.Split();

                string name = input[0];
                string going = name + " is going!";
                string notGoing = name + " is not going!";

                if (line == notGoing)
                {
                    if (names.Any(x => x == name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
                else
                {
                    if (names.Any(x => x == name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
