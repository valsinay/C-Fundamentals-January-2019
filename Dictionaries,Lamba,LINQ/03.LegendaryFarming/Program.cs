using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            var keyMaterials = new Dictionary<string, int>();
            var junk = new SortedDictionary<string, int>();

            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;


            bool isFound = false;
            while (true)
            {
                string[] input = Console.ReadLine()
                    .Split()
                    .ToArray();

                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    isFound = UpdateSequence(material, quantity, keyMaterials, isFound, junk);
                    if (isFound) return;
                }

            }
        }

        private static void PrintResult(Dictionary<string, int> keyMaterials, SortedDictionary<string, int> junk)
        {
            foreach (var item in keyMaterials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junk)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }

        private static bool UpdateSequence(string material, int quantity, Dictionary<string, int> keyMaterials, bool isFound, SortedDictionary<string, int> junk)
        {
            if (material == "shards" || material == "fragments" || material == "motes")
            {
                if (!keyMaterials.ContainsKey(material))
                {
                    keyMaterials.Add(material, 0);
                }
                keyMaterials[material] += quantity;

                if (keyMaterials.Values.Any(x => x >= 250))
                {
                    var resultMaterial = keyMaterials.First(k => k.Value >= 250).Key;
                    keyMaterials[resultMaterial] -= 250;


                    if (resultMaterial == "shards")
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                    }
                    else if (resultMaterial == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                    }
                    else
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                    }

                    isFound = true;
                    PrintResult(keyMaterials, junk);

                }
            }
            else
            {
                if (!junk.ContainsKey(material))
                {
                    junk.Add(material, 0);
                }
                junk[material] += quantity;

            }

            return isFound;
        }
    }
}
