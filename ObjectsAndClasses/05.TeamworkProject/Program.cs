using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TeamworkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamWork> teams = new List<TeamWork>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split("-");

                string creatorName = input[0];
                string teamName = input[1];

                bool isTeamNameExisting = teams.Any(x => x.Name == teamName);
                bool isCreatorNameExisting = teams.Any(x => x.Creator == creatorName);

                if (!isTeamNameExisting && !isCreatorNameExisting)
                {
                    TeamWork team = new TeamWork(teamName, creatorName);
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
                else if (isTeamNameExisting)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (isCreatorNameExisting)
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                }
            }



            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of assignment")
                {
                    break;
                }

                string[] splittedInput = line.Split("->");

                string user = splittedInput[0];
                string team = splittedInput[1];

                bool isTeamExisting = teams.Any(x => x.Name == team);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(user) || x.Creator == user);
                if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {team} does not exist!");

                }
                if (isAlreadyMember)
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    
                }
                if (isTeamExisting && !isAlreadyMember)
                {
                    int indexOfTeam = teams.FindIndex(x => x.Name == team);
                    teams[indexOfTeam].Members.Add(user);
                  
                }

            }

            List<TeamWork> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x=>x.Members.Count)
                .ThenBy(x=>x.Name)
                .ToList();

            List<TeamWork> teamsWithoutMembers = teams
                .Where(x => x.Members.Count == 0)
               .OrderBy(x=>x.Name)
                .ToList();

            foreach (var team in teamsWithMembers)
            {
                Console.WriteLine(team.Name);
                Console.WriteLine("- " + team.Creator);
                Console.WriteLine(string.Join(Environment.NewLine,team.Members.Select(x=>$"-- {x}")));
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsWithoutMembers)
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class TeamWork
    {
        public string Name  { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }


        public TeamWork(string name, string creator)
        {
            Name = name;
            Creator = creator;
            Members = new List<string>();
        }
    }
}
