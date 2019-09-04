using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                string command = tokens[0];

                if (command == "Delete")
                {
                    int element = int.Parse(tokens[1]);

                    Delete(element, input);


                    
                }
                else if (command == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int position = int.Parse(tokens[2]);

                    input.Insert(position, element);

                }

            }
            Console.WriteLine(string.Join(" ", input));


        }

        private static void Delete(int element, List<int> input)
        {

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == element)
                {
                    input.Remove(input[i]);

                    int elementIndex = i - 1;

                    i = elementIndex;
                }

            }
        }
    }
}
