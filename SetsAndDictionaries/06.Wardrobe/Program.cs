using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> dict = new Dictionary<string, Dictionary<string, int>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string color = input[0];
                string clothes = "";
                if (!dict.ContainsKey(color))
                {
                    dict.Add(color, new Dictionary<string, int>());
                }

                for (int j = 1; j < input.Length; j++)
                {
                    clothes = input[j];
                    if (!dict[color].ContainsKey(clothes))
                    {
                        dict[color].Add(clothes, 0);
                    }
                    dict[color][clothes] += 1;
                }
            }
                string[] lookingFor = Console.ReadLine().Split().ToArray();

                string lookedColor = lookingFor[0];
                string lookedCloth = lookingFor[1];

                foreach (var item in dict)
                {
                    Console.WriteLine($"{item.Key} clothes:");
                    foreach (var item1 in item.Value)
                    {
                        if (lookedColor == item.Key && lookedCloth == item1.Key)
                        {
                            Console.WriteLine($"* {item1.Key} - {item1.Value} (found!)");
                        }
                        else
                        {
                            Console.WriteLine($"* {item1.Key} - {item1.Value}");
                        }
                    }
                }

        }
    }
}
