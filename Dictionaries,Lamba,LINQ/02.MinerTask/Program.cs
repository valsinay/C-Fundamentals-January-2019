using System;
using System.Collections.Generic;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resource = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }
                int number = int.Parse(Console.ReadLine());

                if (!resource.ContainsKey(line))
                {
                    resource.Add(line, number);
                }
                else 
                {
                    resource[line] += number;
                }
            }
            foreach (var item in resource)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
