using System;
using System.Collections.Generic;

namespace _01.BoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            

            for (int i = 0; i < n; i++)
            {
                var value = Console.ReadLine();
                Box<string> box = new Box<string>(value);

                Console.WriteLine(box);
            }
        }
    }
}
