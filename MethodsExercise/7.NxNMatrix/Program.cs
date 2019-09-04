using System;

namespace _7.NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrix = int.Parse(Console.ReadLine());

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int matrix)
        {
            for (int i = 0; i < matrix; i++)
            {
                for (int j = 0; j < matrix; j++)
                {
                    Console.Write(matrix + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
