using System;
using System.Linq;

namespace MultidimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] matrix = new int[size,size];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                int[] rows = Console.ReadLine().Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            int primary = 0;
            int secondary = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primary += matrix[i, i];
                secondary += matrix[i, matrix.GetLength(1) - i - 1];
            }
            Console.WriteLine(Math.Abs(primary-secondary));
        }
    }
}
