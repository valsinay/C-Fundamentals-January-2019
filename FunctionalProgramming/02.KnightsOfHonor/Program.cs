using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string,string> transforme = name => "Sir " + name;
            string[] input = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(transforme).ToArray();

            Action<string[]> print = c => Console.WriteLine(string.Join(Environment.NewLine, c));
            print(input);

        }
    }
}
