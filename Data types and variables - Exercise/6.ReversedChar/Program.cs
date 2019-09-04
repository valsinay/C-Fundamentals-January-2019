using System;

namespace _6.ReversedChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = Console.ReadLine();
            string secondLine = Console.ReadLine();
            string thirdLine = Console.ReadLine();

            Console.WriteLine(string.Join(" ",thirdLine,secondLine,firstLine));

        }
    }
}
