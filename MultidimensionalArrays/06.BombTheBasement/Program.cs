using System;
using System.Linq;

namespace _06.BombTheBasement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] bomb = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombRow = bomb[0];
            int bombCol = bomb[1];
            int bombPower = bomb[2];

            int[,] matrix = new int[input[0], input[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));
                    if (distance<=bombPower)
                    {
                        matrix[row, col] = 1;
                    }
                    else
                    {
                        matrix[row, col] = 0;
                    }
                   
                }
            }
            int[][] secondMatrix = new int[input[1]][];

            for (int row = 0; row < input[1]; row++)
            {
                secondMatrix[row] = new int[input[0]];
                for (int col = 0; col < input[0]; col++)
                {
                    secondMatrix[row][col] = matrix[col, row];
                }
                secondMatrix[row] = secondMatrix[row].OrderByDescending(x => x).ToArray();
            }
            for (int row = 0; row < input[0]; row++)
            {
                for (int col = 0; col < input[1]; col++)
                {
                    matrix[row, col] = secondMatrix[col][row];
                }

            }
            for (int i = 0; i < input[0]; i++)
            {
                for (int j = 0; j < input[1]; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
