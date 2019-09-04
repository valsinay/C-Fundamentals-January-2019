using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.MeTube
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int[]> input = new Dictionary<string, int[]>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "stats time")
                {
                    break;
                }
                if (line.Contains("-"))
                {
                    string[] tokens = line.Split("-");
                    string name = tokens[0];
                    int views = int.Parse(tokens[1]);

                    if (!input.ContainsKey(name))
                    {

                        input[name] = new int[2];
                    }
                    
                        input[name][0] += views;
                  
                }
                else if (line.Contains(":"))
                {
                    string[] tokens = line.Split(":");
                    string command = tokens[0];
                    string name = tokens[1];
                    if (input.ContainsKey(name))
                    {
                        if (command == "like")
                        {
                            input[name][1]++;
                           
                        }
                        else if (command == "dislike")
                        {
                            input[name][1]--;

                        }
                    }
                }
            }
            string sorting =Console.ReadLine();

            if (sorting == "by likes")
            {
                foreach (var item in input.OrderByDescending(x=>x.Value[1]))
                {
                    Console.WriteLine($"{item.Key} - {item.Value[0]} views - {item.Value[1]} likes");
                }
            }
            else if (sorting=="by views")
            {
                foreach (var item in input.OrderByDescending(x => x.Value[0]))
                {
                    Console.WriteLine($"{item.Key} - {item.Value[0]} views - {item.Value[1]} likes");
                }
            }
        }
    }
}
