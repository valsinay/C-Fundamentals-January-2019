using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        
            var namePoints = new Dictionary<string, int>();
            var languageCount = new Dictionary<string,int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] tokens = input
                    .Split("-");

                string userName = tokens[0];
                string language = tokens[1];

                if (tokens.Length==2)
                {
                    namePoints.Remove(userName);
                    continue;
                }
                int points = int.Parse(tokens[2]);

                if (!namePoints.ContainsKey(userName))
                {
                    namePoints.Add(userName, points);
                }
                else
                {
                    if (points > namePoints[userName])
                    {
                        namePoints[userName] = points;
                    }
                   
                }

                if (!languageCount.ContainsKey(language))
                {
                    languageCount.Add(language, 1);
                }
                else
                {
                    languageCount[language]++;
                }

            }
                Console.WriteLine("Results:");
                Console.WriteLine(string.Join(Environment.NewLine,namePoints
                    .OrderByDescending(x=>x.Value)
                    .ThenBy(x=>x.Key)
                    .Select(a=>$"{a.Key} | {a.Value}")));


                Console.WriteLine("Submissions:");
                Console.WriteLine(string.Join(Environment.NewLine, languageCount
                    .OrderByDescending(x => x.Value)
                    .ThenBy(x => x.Key)
                    .Select(x => $"{x.Key} - {x.Value}")));
        }
    }
}



