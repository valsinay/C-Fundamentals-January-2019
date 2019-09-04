using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> explanations = new Dictionary<string, List<string>>();

            var wordsAndDefinitions = Console.ReadLine()
                   .Split(" | ")
                   .ToList();

            var words = Console.ReadLine()
                .Split(" | ")
                .ToList();

            string endLine = Console.ReadLine();

            for (int i = 0; i < wordsAndDefinitions.Count; i++)
            {
                var input = wordsAndDefinitions[i].Split(": ");

                string word = input[0];
                string definition = input[1];

                if (!explanations.ContainsKey(word))
                {
                    explanations.Add(word, new List<string>());
                    explanations[word].Add(definition);
                }
                else
                {
                    explanations[word].Add(definition);
                }
            }
            foreach (var word in explanations.OrderBy(x => x.Key.Length))
            {
                if (words.Contains(word.Key))
                {
                    Console.WriteLine($"{word.Key}");
                    foreach (var definition in word.Value.OrderByDescending(x => x.Length))
                    {
                        Console.WriteLine($" –{definition}");
                    }
                }
                
            }
            if (endLine == "List")
            {
                foreach (var word in explanations.Keys.OrderBy(x => x))
                {
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }
        }
    }
}
