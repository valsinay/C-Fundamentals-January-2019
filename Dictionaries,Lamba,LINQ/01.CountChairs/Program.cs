using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountChairs
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();
            
           var saved = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] characters = input[i].ToCharArray();

                foreach (var item in characters)
                {

                    if (!saved.ContainsKey(item))
                    {
                        saved[item] = 0;
                    }
                    saved[item]++;
                }
            }
            foreach (var word in saved)
            {
                Console.WriteLine($"{word.Key} -> {word.Value}");
            }
        }
    }
}