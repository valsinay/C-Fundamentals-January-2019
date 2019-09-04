using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "Add")
                {
                    int numberPassengers = int.Parse(tokens[1]);
                    input.Insert(input.Count, numberPassengers);
                }
                else
                {
                    int numberPassengersToAdd = int.Parse(tokens[0]);

                    for (int i = 0; i < input.Count; i++)
                    {
                        int sum = input[i] + numberPassengersToAdd;

                        if (input[i] <= maxCapacity && sum <= maxCapacity)
                        {
                            input[i] += numberPassengersToAdd;

                            break;
                        }
                    }
                }
                Console.WriteLine(string.Join(" ", input));
            }
        }
    }
}
