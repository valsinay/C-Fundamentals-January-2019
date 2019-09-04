using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        private static object list;

        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                 .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            var newArr = new List<string>();

            string input = string.Empty;

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                input += numbers[i];
                input = input.Replace(" ", "");
            }

            for (int i = 0; i < input.Length; i++)
            {
                char number = input[i];
                char last = input.Last();

                if (number != last)
                {
                    Console.Write(number + " ");
                }
                else
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
