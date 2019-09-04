using System;

namespace _2.PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                for (int j = 1; j < input-i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
