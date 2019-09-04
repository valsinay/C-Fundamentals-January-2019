using System;
using System.Linq;

namespace _02.SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] rowsAndColumns = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            char[,] matrix = new char[rowsAndColumns[0], rowsAndColumns[1]];

            int count = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                char[] rows = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rows[col];
                }
            }

            for (int i = 0; i < matrix.GetLength(0)-1; i++)
            {


                for (int j = 0; j < matrix.GetLength(1)-1; j++)
                {
                    char current = matrix[i, j];
                    if (current == matrix[i,j+1] && current==matrix[i+1,j] && current==matrix[i+1,j+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
