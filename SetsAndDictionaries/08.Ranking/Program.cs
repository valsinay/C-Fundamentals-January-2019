using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            SortedDictionary<string, Dictionary<string, int>> userContests = new SortedDictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of contests")
                {
                    break;
                }

                string[] tokens = line.Split(":");
                string contest = tokens[0];
                string passwordContest = tokens[1];

                contests.Add(contest, passwordContest);
            }
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of submissions")
                {
                    break;
                }
                string[] tokens = line.Split("=>");
                string contest = tokens[0];
                string passwordCheck = tokens[1];
                string username = tokens[2];
                int points = int.Parse(tokens[3]);

                if (contests.ContainsKey(contest) && contests.ContainsValue(passwordCheck))
                {
                    if (!userContests.ContainsKey(username))
                    {
                        userContests.Add(username, new Dictionary<string, int>());

                        userContests[username].Add(contest, points);
                    }
                    if (!userContests[username].ContainsKey(contest))
                    {
                        userContests[username].Add(contest, points);
                    }
                    if (userContests[username][contest] < points)
                    {
                        userContests[username][contest] = points;

                    }
                   
                }
            }
            Dictionary<string, int> bestCandidate = new Dictionary<string, int>();

            foreach (var kvp in userContests)
            {
                bestCandidate[kvp.Key] = kvp.Value.Values.Sum();
            }

            string bestName = bestCandidate.Keys.Max();
            int bestResult = bestCandidate.Values.Max();

            foreach (var kvp in bestCandidate)
            {
                if (kvp.Value == bestResult)
                {
                    Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");

                }
            }
            Console.WriteLine("Ranking:");
            foreach (var kvp in userContests)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var item in userContests[kvp.Key].OrderByDescending(x=>x.Value))
                {
                    
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }
        }
    }
}
