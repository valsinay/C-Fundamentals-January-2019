using System;

namespace _2.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLine = char.Parse(Console.ReadLine());
            char secondLine = char.Parse(Console.ReadLine());
            char thirdLine = char.Parse(Console.ReadLine());

            string output = string.Join("",firstLine, secondLine, thirdLine);
            Console.WriteLine(output);
        }
    }
}
