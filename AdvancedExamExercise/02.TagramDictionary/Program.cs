using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.TagramDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userInfo = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                if (line.Contains("ban"))
                {
                    string[] tokens = line.Split();
                    string name = tokens[1];

                    userInfo.Remove(name);
                }
                else
                {
                    string[] tokens = line.Split(" -> ");
                    string name = tokens[0];
                    string tag = tokens[1];
                    int likes = int.Parse(tokens[2]);

                    if (!userInfo.ContainsKey(name))
                    {
                        userInfo.Add(name, new Dictionary<string, int>());
                        userInfo[name].Add(tag, likes);
                        
                    }
                    else if (!userInfo[name].ContainsKey(tag))
                    {
                        userInfo[name].Add(tag, likes);
                    }

                    else
                    {
                       
                        userInfo[name][tag] += likes;
                    }
                }
            }

            foreach (var person in userInfo.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Value.Keys.Count()))
            {
                Console.WriteLine(person.Key);
                foreach (var item in person.Value)
                {
                    Console.WriteLine($"- {item.Key}: {item.Value}");
                }
            }
        }
    }
}
