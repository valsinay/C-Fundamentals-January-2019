using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.SoftUniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "course start")
                {
                    break;
                }
                string[] tokens = line.Split(":");
                string command = tokens[0];

                if (command == "Add")
                {
                    string title = tokens[1];

                    if (!input.Contains(title))
                    {
                        input.Add(title);
                    }
                }
                else if (command == "Insert")
                {
                    string title = tokens[1];
                    int index = int.Parse(tokens[2]);

                    if (!input.Contains(title))
                    {
                        input.Insert(index, title);
                    }
                }
                else if (command == "Remove")
                {
                    string title = tokens[1];

                    if (input.Contains(title))
                    {
                        int index = input.IndexOf(title);
                        if (input.Contains($"{title}-Exercise"))
                        {
                            input.RemoveAt(index+1);
                        }
                        input.Remove(title);
                    }
                }
                else if (command == "Swap")
                {
                    string firstTitle = tokens[1];
                    string secondTitle = tokens[2];

                    int firstIndex = input.IndexOf(firstTitle);
                    int secondIndex = input.IndexOf(secondTitle);

                    if (firstIndex == -1 || secondIndex == -1)
                    {
                        continue;
                    }
                    
                    else
                    {
                        input[firstIndex] = secondTitle;
                        input[secondIndex] = firstTitle;
                        if (input.Contains(($"{firstTitle}-Exercise")))
                        {
                            input.RemoveAt(firstIndex + 1);
                            input.Insert(secondIndex + 1, ($"{firstTitle}-Exercise"));
                        }
                        if (input.Contains(($"{secondTitle}-Exercise")))
                        {

                            input.RemoveAt(secondIndex + 1);
                            input.Insert(firstIndex + 1, ($"{secondTitle}-Exercise"));
                        }
                    }



                }
                else if (command == "Exercise")
                {
                    string lesson = tokens[1];

                    int indexOfLesson = input.IndexOf(lesson);

                    if (!input.Contains(lesson))
                    {
                        input.Add(lesson);
                        input.Add($"{lesson}-Exercise");
                    }
                    else if (input.Contains(lesson) && !input.Contains(($"{lesson}-Exercise")))
                    {
                        int index = input.IndexOf(lesson);
                        input.Insert(index + 1, ($"{lesson}-Exercise"));
                    }
                }
            }
            for (int i = 0; i < input.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
