using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> words = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char letter = input[i];
                if (!words.ContainsKey(letter))
                {
                    words.Add(letter, 0);
                }
                words[letter]++;

            }
            foreach (var item in words.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
