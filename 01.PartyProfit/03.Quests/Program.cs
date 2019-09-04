using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Quests
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> journal = Console.ReadLine()
                .Split(new string[] { ", ", }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Retire!")
                {
                    break;
                }
                string[] tokens = line.Split(" - ");
                string command = tokens[0];
               

                if (command=="Start")
                {
                    string quest = tokens[1];
                    if (!journal.Contains(quest))
                    {
                        journal.Add(quest);
                    }
                }
                else if (command=="Complete")
                {
                    string quest = tokens[1];
                    if (journal.Contains(quest))
                    {
                        journal.Remove(quest);
                    }
                }
                else if (command=="Side Quest")
                {
                    string[] sideCommand = tokens[1].Split(":");
                    string quest = sideCommand[0];
                    string sideQuest = sideCommand[1];

                    if (journal.Contains(quest))
                    {
                        if (journal.Contains(sideQuest))
                        {
                            continue;
                        }
                        else
                        {
                            int index = journal.IndexOf(quest);
                            journal.Insert(index + 1, sideQuest);

                        }
                    }
                }
                else if (command=="Renew")
                {
                    string quest = tokens[1];
                    if (journal.Contains(quest))
                    {
                        journal.Remove(quest);
                        journal.Add(quest);

                    }
                }
            }
            for (int i = 0; i < journal.Count; i++)
            {
                var item = journal[journal.Count - 1];
                if (item == journal[i])
                {
                    Console.WriteLine(journal[i]);
                    break;
                }
                Console.Write(journal[i] + ", ");
               
            }
           

        }
    }
}
