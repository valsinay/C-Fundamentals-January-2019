using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.MobaChallenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> playerPositionSkill = new Dictionary<string, Dictionary<string, int>>();
            
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Season end")
                {
                    break;
                }

                if (input.Contains(" -> "))
                {
                    var inputche = input.Split(" -> ",StringSplitOptions.RemoveEmptyEntries).ToList();
                    string player = inputche[0];
                    string position = inputche[1];
                    int skills = int.Parse(inputche[2]);

                    if (!playerPositionSkill.ContainsKey(player))
                    {
                        playerPositionSkill.Add(player, new Dictionary<string, int>());
                        playerPositionSkill[player].Add(position, skills);
                    }
                    else if (playerPositionSkill.ContainsKey(player))
                    {
                        if (playerPositionSkill[player].ContainsKey(position))
                        {
                            if ((playerPositionSkill[player][position] < skills))
                            {
                                (playerPositionSkill[player][position]) = skills;
                            }
                        }
                        else
                        {
                            playerPositionSkill[player].Add(position, skills);
                        }
                    }
                    
                }
                else if (input.Contains(" vs "))
                {
                    var inputche = input.Split(" vs ").ToList();
                    string firstPlayer = inputche[0];
                    string secondPlayer = inputche[1];

                    string playerToRemove = ""; 
                    if (!playerPositionSkill.ContainsKey(firstPlayer) || !playerPositionSkill.ContainsKey(secondPlayer))
                    {
                        continue;
                    }
                    foreach (var firstPosition in playerPositionSkill[firstPlayer])
                    {
                        foreach (var secondPosition in playerPositionSkill[secondPlayer])
                        {
                            if (firstPosition.Key == secondPosition.Key)
                            {
                                if (playerPositionSkill[firstPlayer].Values.Sum() > playerPositionSkill[secondPlayer].Values.Sum())
                                {
                                    playerToRemove = secondPlayer;
                                }
                                else if ((playerPositionSkill[firstPlayer].Values.Sum() < playerPositionSkill[secondPlayer].Values.Sum()))
                                {
                                    playerToRemove = firstPlayer;
                                }
                            }
                        }
                    }
                    playerPositionSkill.Remove(playerToRemove);
                    
                }
            }
            foreach (var player in playerPositionSkill.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value.Values.Sum()} skill");
                foreach (var playa in player.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"- {playa.Key} <::> {playa.Value}");
                }
            }

        }
    }
}
