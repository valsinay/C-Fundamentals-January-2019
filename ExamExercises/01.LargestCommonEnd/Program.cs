using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.LargestCommonEnd
{
    class Program
    {
        private const string firstWord = "DONT_REMOVE_ME";
        private const string removableWords = "REMOVE_ME";

        static void Main(string[] args)
        {
            StringBuilder updateInput = new StringBuilder();

            List<string> input = Console.ReadLine()
                .Split(new string[] { }, StringSplitOptions.RemoveEmptyEntries)
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
                    MergeCommand(input, tokens, updateInput);
                }
                else if (command == "divide")
                {
                    DivideCommand(input, tokens, updateInput);
                }

            }

            Console.WriteLine(string.Join(" ", input));
        }

        private static void DivideCommand(List<string> input, string[] tokens, StringBuilder updateInput)
        {
            int wordIndex = int.Parse(tokens[1]);
            int parts = int.Parse(tokens[2]);

            if (wordIndex >= input.Count)
            {
                return;
            }


            string word = input[wordIndex];
            int partLength = word.Length / parts;
            var result = new List<string>();

            if (word.Length % 2 == 0)
            {
                for (int i = 0; i < parts*partLength; i+=partLength)
                {
                    result.Add(word.Substring(i, partLength));
                }

                input.RemoveAt(wordIndex);
                input.InsertRange(wordIndex, result);
            }
            else
            {
                string lastChar = word.Last().ToString();
                
                word.Remove(word.LastIndexOf(lastChar));

                for (int i = 0; i < parts * partLength; i += partLength)
                {
                    if (i == parts*partLength - partLength)
                    {
                        string wordToAdd = word.Substring(i, partLength) + lastChar;
                        result.Add(wordToAdd);
                    }
                    else
                    {
                        result.Add(word.Substring(i, partLength));
                    }
                }

                input.RemoveAt(wordIndex);
                input.InsertRange(wordIndex, result);
            }
        }

        private static void MergeCommand(List<string> input, string[] tokens, StringBuilder updateInput)
        {
            int startIndex = int.Parse(tokens[1]);
            int endIndex = int.Parse(tokens[2]);
            if (endIndex >= input.Count)
            {
                endIndex = input.Count - 1;
                if (startIndex >= endIndex)
                {
                    return;
                }
            }
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            if (endIndex <0)
            {
                return;
            }

            for (int i = startIndex; i <= endIndex; i++)
            {
                string word = input[i];
                updateInput.Append(word);
                if (i == startIndex)
                {
                    input[i] = firstWord;
                }
                else
                {
                    input[i] = removableWords;
                }
            }
            input.RemoveAll(x => x == removableWords);
            int index = input.IndexOf(firstWord);
            input[index] = updateInput.ToString();

            updateInput.Clear();
        }
    }
}

