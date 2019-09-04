using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();
                string[] tokens = line.Split();

                string command = tokens[0];

                if (command == "End")
                {
                    break;
                }

                else if (command == "Add")
                {
                    int number = int.Parse(tokens[1]);

                    numbers.Add(number);
                }

                else if (command == "Insert")
                {
                    int number = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);

                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(index, number);
                }

                else if (command == "Remove")
                {
                    int index = int.Parse(tokens[1]);
                    if (index > numbers.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(index);
                }

                else if (command == "Shift")
                {
                    string direction = tokens[1];
                    int rotations = int.Parse(tokens[2]);

                    if (direction == "left")
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            int temp = numbers.First();
                            for (int j = 0; j < numbers.Count - 1; j++)
                            {
                                numbers[j] = numbers[j + 1];
                            }
                            numbers[numbers.Count - 1] = temp;
                        }
                    }
                    else
                    {
                        for (int i = 0; i < rotations; i++)
                        {
                            int temp = numbers.Last();
                            for (int j = numbers.Count - 1; j > 0; j--)
                            {
                                numbers[j] = numbers[j - 1];
                            }
                            numbers[0] = temp;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
