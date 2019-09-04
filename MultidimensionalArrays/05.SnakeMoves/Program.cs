using System;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            long maxSum = -1;
            int maxRow = -1;
            int maxCol = -1;

            for (int i = 0; i < matrix.GetLength(0)-2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1)-2; j++)
                {
                    long currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i, j + 2] + matrix[i + 1, j] + matrix[i + 1, j + 1]
                        + matrix[i + 1, j + 2] + matrix[i + 2, j] + matrix[i + 2, j + 1] + matrix[i + 2, j + 2];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = i;
                        maxCol = j;

                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int i = maxRow; i < maxRow+3; i++)
            {
                for (int j = maxCol; j < maxCol +3; j++)
                {
                    Console.Write( matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
