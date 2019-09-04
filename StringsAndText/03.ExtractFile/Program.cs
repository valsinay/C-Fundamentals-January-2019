using System;
using System.Linq;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("\\");

            string lastElement = input.ElementAt(input.Length - 1);

            string[] element = lastElement.Split(".");

            Console.WriteLine($"File name: {element[0]}");
            Console.WriteLine($"File extension: { element[1]}");

        }
    }
}
