using System;
using System.Collections.Generic;

namespace _04.Caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            List<char> after = new List<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                int num = symbol;
                num += 3;

                char number = Convert.ToChar(num);
                after.Add(number);
                
            }

            foreach (var item in after)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
