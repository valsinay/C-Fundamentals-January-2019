using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            char[,] matrix = new char[input[0], input[1]];

            var snake = Console.ReadLine();
           
            Queue<char> queue = new Queue<char>(snake);
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    var charToMove = queue.Peek();
                    queue.Dequeue();
                    queue.Enqueue(charToMove);

                    matrix[row, col] = charToMove;

                    Console.Write(matrix[row,col] + "");

                }
                Console.WriteLine();

            }




        }
    }
}
