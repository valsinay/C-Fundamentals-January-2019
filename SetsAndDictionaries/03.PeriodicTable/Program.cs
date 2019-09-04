using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> hash = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var elements = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                for (int j = 0; j < elements.Length; j++)
                {
                    hash.Add(elements[j]);
                }   
            }
            foreach (var item in hash.OrderBy(x=>x))
            {
                Console.Write(item + " ");
            }
        }
    }
}
