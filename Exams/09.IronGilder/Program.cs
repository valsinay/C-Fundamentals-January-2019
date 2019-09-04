using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.IronGilder
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> townAndTime = new Dictionary<string, int>();
            Dictionary<string, int> townAndPassengers = new Dictionary<string, int>();
            
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { ":", "->" }, StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Slide rule")
                {
                    break;
                }

                string town = input[0];
                int passengers = int.Parse(input[2]);

                if (input[1] == "ambush")
                {
                    if (townAndTime.ContainsKey(town))
                    {
                        townAndTime[town] = 0;
                        townAndPassengers[town] -= passengers;
                    }
                }
                else
                {
                    int time = int.Parse(input[1]);
                    if (!townAndTime.ContainsKey(town))
                    {
                        townAndTime.Add(town, time);
                        townAndPassengers.Add(town, 0);
                    }
                    townAndPassengers[town] += passengers;
                    if (townAndTime[town] > time || townAndTime[town] == 0)
                    {
                        townAndTime[town] = time;
                    }
                }
            }
            foreach (var town in townAndTime.OrderBy(x => x.Value).ThenBy(x => x.Key)
                .Where(x => x.Value != 0))
            {
                if (townAndPassengers[town.Key] > 0)
                {
                    Console.WriteLine($"{town.Key} -> Time: {town.Value} -> Passengers: {townAndPassengers[town.Key]}");

                }
            }
        }
    }
}
