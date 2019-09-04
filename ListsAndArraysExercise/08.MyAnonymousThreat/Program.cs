using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.MyAnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "3:1")
                {
                    break;
                }

                string[] tokens = line.Split();
                string command = tokens[0];

                if (command == "merge")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);

                    if (startIndex<0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex > input.Count-1)
                    {
                        endIndex = input.Count - 1;
                    }
                    if (startIndex > input.Count-1 || endIndex < 0)
                    {
                        continue;
                    }
                    Merge(input, startIndex, endIndex);

                }
                else if (command == "divide")
                {
                    int index = int.Parse(tokens[1]);
                    int parts = int.Parse(tokens[2]);

                    string element = input[index];
                    input.RemoveAt(index);
                    List<string> newWords= Divide(element, parts);

                    input.InsertRange(index, newWords);
                }
            }
            Console.WriteLine(string.Join(" ",input));
        }

        private static List<string> Divide(string element, int parts)
        {
            List<string> newWords = new List<string>();

            int partLength = element.Length / parts;

            for (int i = 0; i < parts; i++)
            {

                string newWord = element.Substring(i * partLength, partLength);
                if (i==parts-1)
                {
                    newWord = element.Substring(i * partLength);
                }
                newWords.Add(newWord);
            }
            return newWords;
        }

        

        private static void Merge(List<string> input, int startIndex, int endIndex)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = startIndex; i <= endIndex; i++)
            {
                string words = input[i];

                sb.Append(words);
            }
            input.RemoveRange(startIndex, endIndex - startIndex + 1);
            input.Insert(startIndex, sb.ToString());

           
        }
    }
}
