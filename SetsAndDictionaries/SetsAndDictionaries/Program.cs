using System;
using System.Collections.Generic;

namespace SetsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string namesToAdd = Console.ReadLine();

                names.Add(namesToAdd);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
