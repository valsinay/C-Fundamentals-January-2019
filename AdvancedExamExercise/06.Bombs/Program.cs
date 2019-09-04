using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int i = 0; i < matrix.Length; i++)
            {
                int[] row = Console.ReadLine().Split()
                    .Select(int.Parse)
                    .ToArray();

                matrix[i] = row;
            }

            var coordinates = Console.ReadLine().Split();

            for (int i = 0; i < coordinates.Length; i++)
            {
                var splited = coordinates[i].Split(",");
                int row = int.Parse(splited[0]);
                int col = int.Parse(splited[1]);

                int bomb = matrix[row][col];

                BombCells(row, col, matrix);
            }

            PrintAlive(matrix);
        }

        private static void PrintAlive(int[][] matrix)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                int[] aliveCells = matrix[i].Where(x => x > 0).ToArray();

                count += aliveCells.Length;
                sum += aliveCells.Sum();
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ",item));
            }
        }

        private static void BombCells(int row, int col, int[][] matrix)
        {
            int damage = matrix[row][col];

            if (damage > 0)
            {
                BombCell(row - 1, col - 1, damage, matrix);
                BombCell(row - 1, col, damage, matrix);
                BombCell(row - 1, col + 1, damage, matrix);
                BombCell(row, col - 1, damage, matrix);
                BombCell(row, col + 1, damage, matrix);
                BombCell(row + 1, col - 1, damage, matrix);
                BombCell(row + 1, col, damage, matrix);
                BombCell(row + 1, col + 1, damage, matrix);
                matrix[row][col] = 0;
            }
        }

        private static void BombCell(int row, int col, int damage, int[][] matrix)
        {
            if (row >= 0 && row < matrix.Length &&
                col >= 0 && col < matrix.Length &&
                matrix[row][col] > 0)
            {
                matrix[row][col] -= damage;
            }
        }
    }
}
