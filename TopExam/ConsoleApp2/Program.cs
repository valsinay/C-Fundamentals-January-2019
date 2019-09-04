using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bands = new Dictionary<string, List<string>>();
            Dictionary<string, int> bandTime = new Dictionary<string, int>();

            int totalTime = 0;
            string finalBandName = "";
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "start of concert")
                {
                     finalBandName = Console.ReadLine();
                    break;  
                }

                string[] tokens = line.Split("; ");

                string command = tokens[0];
                if (command=="Add")
                {
                    
                    string bandName = tokens[1];
                    var member = new List<string>(tokens[2].Split(", "));
                    if (!bands.ContainsKey(bandName))
                    {
                        bands.Add(bandName, member);
                        
                    }
                    else if (bands.ContainsKey(bandName))
                    {
                        for (int i = 0; i < member.Count; i++)
                        {
                            
                            string currentMember = member[i];

                            if (!bands[bandName].Contains(currentMember))
                            {
                                bands[bandName].Add(currentMember);
                            }

                        }
                    }
                   
                }
                else if (command =="Play")
                {
                    string bandName = tokens[1];
                    int time = int.Parse(tokens[2]);

                    
                    if (!bandTime.ContainsKey(bandName))
                    {
                        bandTime.Add(bandName, time);
                    }
                    else
                    {
                        bandTime[bandName] += time;
                    }
                    totalTime += time;
                }
            }
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var band in bandTime.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }
            Console.WriteLine($"{finalBandName}");
            foreach (var band in bands.Where(x=>x.Key == finalBandName))
            {
                List<string> finals = band.Value;
                foreach (var item in finals)
                {
                    Console.WriteLine($"=> {item}");
                }
                break;
               
            }
        }
    }
}
