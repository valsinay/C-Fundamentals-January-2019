using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Vloggers
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new HashSet<string>();
            var userFollowers = new Dictionary<string, HashSet<string>>();
            var userFollowings = new Dictionary<string, HashSet<string>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Statistics")
                {
                    break;
                }

                string[] tokens = line.Split();
                if (tokens.Contains("joined"))
                {
                    string vloggerName = tokens[0];
                    vloggers.Add(vloggerName);
                    if (!userFollowers.ContainsKey(vloggerName) && !userFollowings.ContainsKey(vloggerName))
                    {
                        userFollowers.Add(vloggerName, new HashSet<string>());
                        userFollowings.Add(vloggerName, new HashSet<string>());
                    }
                }
                else
                {
                    string follows = tokens[0];
                    string followed = tokens[2];

                    if (vloggers.Contains(follows) && vloggers.Contains(followed) && follows != followed)
                    {
                        userFollowers[followed].Add(follows);
                        userFollowings[follows].Add(followed);
                    }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 1;

            foreach (var kvp in userFollowers.OrderByDescending(x => x.Value.Count).ThenBy(x => userFollowings[x.Key].Count))
            {
                Console.WriteLine($"{count}. {kvp.Key} : {userFollowers[kvp.Key].Count} followers, {userFollowings[kvp.Key].Count} following");

                if (count == 1)
                {
                    foreach (var followers in userFollowers[kvp.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {followers}");
                    }
                }
                count++;
            }
        }
    }
}
