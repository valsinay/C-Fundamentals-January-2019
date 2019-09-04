using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.SoftUniExamResultClassObject
{
    public class User
    {
        public User(string username, string language, int points)
        {
            this.Username = username;
            this.Language = language;
            this.Points = points;
        }

        public string Username { get; set; }
        public string Language { get; set; }
        public int Points { get; set; }

    }

    public class Submission
    {
        public string Name { get; set; }

        public int Points { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>();
            List<Submission> submissions = new List<Submission>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] tokens = line.Split("-");

                string name = tokens[0];
                string language = tokens[1];

                if (tokens.Any(x => x == "banned"))
                {
                    var userToRemove = users.First(u => u.Username == name);
                    users.Remove(userToRemove);

                    continue;
                }

                int points = int.Parse(tokens[2]);

                if (users.Any(x => x.Username == name))
                {
                    var user = users.First(x => x.Username == name);
                    if (points > user.Points)
                    {
                        user.Points = points;
                    }
                }
                else
                {
                    var user = new User(name, language, points);
                    users.Add(user);

                }

                if (!submissions.Any(x => x.Name == language))
                {
                    submissions.Add(new Submission
                    {
                        Name = language,
                        Points = 1
                    });
                }
                else
                {
                    submissions.First(x => x.Name == language).Points++;
                    
                }

            }

            PrintResult(users, submissions);
            

        }

        private static void PrintResult(List<User> users, List<Submission> submissions)
        {
            Console.WriteLine("Results:");
            foreach (var user in users.OrderByDescending(x => x.Points).ThenBy(x => x.Username))
            {
                Console.WriteLine($"{user.Username} | {user.Points}");

            }

            Console.WriteLine("Submissions:");
            foreach (var sub in submissions.OrderByDescending(x => x.Points).ThenBy(x => x.Name))
            {
                Console.WriteLine($"{sub.Name} - {sub.Points}");
            }
        }
    }
}

