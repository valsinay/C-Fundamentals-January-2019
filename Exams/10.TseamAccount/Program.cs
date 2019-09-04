using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.TseamAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var games = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Play!")
                {
                    break;
                }

                string[] tokens = line.Split();

                string command = tokens[0];
               
                if (command == "Install")
                {
                    string game = tokens[1];
                    if (!games.Contains(game))
                    {
                        games.Add(game);

                    }
                }
                else if (command == "Uninstall")
                {
                    string game = tokens[1];
                    games.Remove(game);
                }
                else if (command == "Update")
                {
                    string game = tokens[1];
                    if (games.Contains(game))
                    {
                        games.Remove(game);
                        games.Add(game);
                    }
                }
                else if (command=="Expansion")
                {
                    string[] expansionCommand = tokens[1].Split("-");
                    string game = expansionCommand[0];
                    string expansion = expansionCommand[1];

                    if (games.Contains(game))
                    {
                        string expansionName = game + ":" + expansion;
                        int gameIndex = games.IndexOf(game);
                        games.Insert(gameIndex + 1, expansionName);
                    }
                }
            }

            Console.WriteLine(string.Join(" ",games));
        }
    }
}
