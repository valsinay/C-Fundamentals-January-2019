using System;
using System.Linq;

namespace FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split();
            Action<string> print = name => Console.WriteLine(name);

            for (int i = 0; i < input.Length; i++)
            {
                print(input[i]);
            }
        }
    }
}
