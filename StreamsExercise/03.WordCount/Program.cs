using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string>();

            using (var wordReader = new StreamReader("../../../words.txt"))
            {
                while (true)
                {
                    string line = wordReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string[] splitedLine = line.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();

                    words.AddRange(splitedLine);
                }
            }

            Dictionary<string, int> wordscount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordscount.ContainsKey(word))
                {
                    wordscount[word] = 0;
                }
            }
            using (var textReader = new StreamReader("../../../text.txt"))
            {
                while (true)
                {
                    string line = textReader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    string symbols = " ";
                    foreach (var charss in line)
                    {
                        if (char.IsPunctuation(charss) && charss != '\'')
                        {
                            symbols += charss;
                        }
                    }
                    string[] splitedLine = line.ToLower()
                        .Split(symbols.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in splitedLine)
                    {
                        if (wordscount.ContainsKey(word))
                        {
                            wordscount[word]++;
                        }
                    }

                }
            }
            var sortedDictionary = wordscount.OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);

            using (var readerResult = new StreamReader("../../../expectedResult.txt"))
            {
                bool isSame = true;

                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} -  {kvp.Value}";
                    string line = readerResult.ReadLine();

                    if (output != line)
                    {
                        isSame = false;
                        break;
                    }
                }
                if (isSame)
                {
                    Console.WriteLine(true);
                }
            }
            using (var writer = new StreamWriter("../../../actualResult.txt"))

            {
                foreach (var kvp in sortedDictionary)
                {
                    string output = $"{kvp.Key} - {kvp.Value}";
                    writer.WriteLine(output);
                }
            }
        }
    }
}
